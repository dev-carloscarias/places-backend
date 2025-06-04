using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Places.Application.Interfaces;
using Places.Domain.Dtos;
using Places.Domain.Entities;
using Places.Domain.Resources;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Places.Infrastructure.Services;

public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;
    private readonly HttpClient _httpClient;
    private readonly ILogger<EmailService> _logger;
    private readonly string appName = string.Empty;
    private readonly string apiKey = string.Empty;
    private readonly string senderEmail = string.Empty;
    private readonly string senderName = string.Empty;
    private readonly string apiUrl = string.Empty;

    public EmailService(
        IConfiguration configuration, 
        HttpClient httpClient,
        ILogger<EmailService> logger)
    {
        _configuration = configuration;
        _httpClient = httpClient;
        _logger = logger;
        
        appName = _configuration["AppSettings:AppName"] ?? "Places";
        apiKey = _configuration["Brevo:ApiKey"] ?? string.Empty;
        senderEmail = _configuration["Brevo:SenderEmail"] ?? string.Empty;
        senderName = _configuration["Brevo:SenderName"] ?? "Places";
        apiUrl = _configuration["Brevo:ApiUrl"] ?? "https://api.brevo.com/v3";

        // Configurar headers del HttpClient para Brevo API
        _httpClient.DefaultRequestHeaders.Clear();
        _httpClient.DefaultRequestHeaders.Add("api-key", apiKey);
        _httpClient.DefaultRequestHeaders.Add("accept", "application/json");
    }

    public async Task<EmailResponse> SendWelcomeEmailAsync(User user, string cc, string bcc)
    {
        var templateId = _configuration["Brevo:Templates:Welcome"];
        
        if (string.IsNullOrEmpty(templateId))
        {
            // Fallback a email sin template si no se encuentra el ID
            var welcomeMessage = $"{Resource.EmailVerificationMessage}\n\n" +
                               $"{Resource.EmailVerificationInstructions.Replace("{0}", appName)}\n\n" +
                               $"Código: {user.EmailCodeValidation}\n\n" +
                               $"{Resource.EmailVerificationThanks.Replace("{0}", appName)}";
            
            return await SendEmailAsync(user.Email, Resource.EmailVerificationTitle, welcomeMessage, cc, bcc);
        }

        var parameters = new Dictionary<string, object>
        {
            { "verification_message", Resource.EmailVerificationMessage },
            { "verification_title", Resource.EmailVerificationTitle },
            { "code_instructions", Resource.EmailVerificationInstructions.Replace("{0}", appName) },
            { "code", user.EmailCodeValidation },
            { "verification_thanks", Resource.EmailVerificationThanks.Replace("{0}", appName) }
        };

        return await SendTemplateEmailAsync(user.Email, int.Parse(templateId), parameters, cc, bcc);
    }

    public async Task<EmailResponse> SendVerificationEmailAsync(User user, string cc, string bcc)
    {
        var templateId = _configuration["Brevo:Templates:Verification"];
        
        if (string.IsNullOrEmpty(templateId))
        {
            // Fallback a email sin template
            var welcomeMessage = $"{Resource.email_welcome_subject}\n\n{Resource.email_welcome_message}";
            return await SendEmailAsync(user.Email, Resource.email_welcome_subject, welcomeMessage, cc, bcc);
        }

        var parameters = new Dictionary<string, object>
        {
            { "welcome", Resource.email_welcome_subject },
            { "welcome_message", Resource.email_welcome_message }
        };

        return await SendTemplateEmailAsync(user.Email, int.Parse(templateId), parameters, cc, bcc);
    }

    public async Task<EmailResponse> SendOwnerRegistrationRequest(User user, string message)
    {
        return await SendEmailAsync(user.Email, "Solicitud de Propietario", message);
    }

    public async Task<EmailResponse> SendOwnerRegistrationResult(User user, string message)
    {
        return await SendEmailAsync(user.Email, "Resolución de Registro de Propietario", message);
    }

    public async Task<EmailResponse> SendSiteRegistrationResult(User user, string message)
    {
        return await SendEmailAsync(user.Email, "Resultado de Registro de Sitio", message);
    }

    public async Task<EmailResponse> SendCodeVerificationResult(string mail, string message)
    {
        return await SendEmailAsync(mail, "Código de Verificación", message);
    }

    public async Task<EmailResponse> SendUserReservationApproved(string email, string message)
    {
        return await SendEmailAsync(email, "Tu reserva ha sido confirmada", message);
    }

    public async Task<EmailResponse> SendOwnerReservationReceived(string email, string message)
    {
        return await SendEmailAsync(email, "Tu sitio ha sido reservado", message);
    }

    /// <summary>
    /// Envía email sin template usando la API REST de Brevo
    /// </summary>
    private async Task<EmailResponse> SendEmailAsync(string email, string subject, string message, string cc = "", string bcc = "")
    {
        try
        {
            if (string.IsNullOrEmpty(email))
            {
                _logger.LogWarning("Intento de envío de email con dirección vacía");
                return new EmailResponse { StatusCode = HttpStatusCode.NoContent };
            }

            if (string.IsNullOrEmpty(apiKey))
            {
                _logger.LogError("API Key de Brevo no configurada");
                return new EmailResponse { StatusCode = HttpStatusCode.Unauthorized };
            }

            var recipients = email.Split(';', StringSplitOptions.RemoveEmptyEntries)
                .Select(e => new { email = e.Trim() }).ToArray();

            var emailData = new
            {
                sender = new { email = senderEmail, name = senderName },
                to = recipients,
                cc = !string.IsNullOrEmpty(cc) 
                    ? cc.Split(';', StringSplitOptions.RemoveEmptyEntries)
                        .Select(e => new { email = e.Trim() }).ToArray() 
                    : null,
                bcc = !string.IsNullOrEmpty(bcc) 
                    ? bcc.Split(';', StringSplitOptions.RemoveEmptyEntries)
                        .Select(e => new { email = e.Trim() }).ToArray() 
                    : null,
                subject = subject,
                textContent = message,
                htmlContent = FormatHtmlMessage(message)
            };

            var jsonContent = JsonSerializer.Serialize(emailData, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            
            var response = await _httpClient.PostAsync($"{apiUrl}/smtp/email", content);
            
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                _logger.LogInformation("Email enviado exitosamente a {Email} usando Brevo. Response: {Response}", 
                    email, responseContent);
                return new EmailResponse { StatusCode = HttpStatusCode.OK };
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError("Error al enviar email a {Email} usando Brevo. Status: {StatusCode}, Error: {Error}", 
                    email, response.StatusCode, errorContent);
                return new EmailResponse { StatusCode = response.StatusCode };
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error inesperado al enviar email a {Email} usando Brevo", email);
            return new EmailResponse { StatusCode = HttpStatusCode.InternalServerError };
        }
    }

    /// <summary>
    /// Envía email usando template de Brevo
    /// </summary>
    private async Task<EmailResponse> SendTemplateEmailAsync(string email, int templateId, Dictionary<string, object> parameters, string cc = "", string bcc = "")
    {
        try
        {
            if (string.IsNullOrEmpty(email))
            {
                _logger.LogWarning("Intento de envío de email con template con dirección vacía");
                return new EmailResponse { StatusCode = HttpStatusCode.NoContent };
            }

            if (string.IsNullOrEmpty(apiKey))
            {
                _logger.LogError("API Key de Brevo no configurada");
                return new EmailResponse { StatusCode = HttpStatusCode.Unauthorized };
            }

            var recipients = email.Split(';', StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim()).ToArray();

            var emailData = new
            {
                sender = new { email = senderEmail, name = senderName },
                to = recipients.Select(e => new { email = e }).ToArray(),
                cc = !string.IsNullOrEmpty(cc) 
                    ? cc.Split(';', StringSplitOptions.RemoveEmptyEntries)
                        .Select(e => new { email = e.Trim() }).ToArray() 
                    : null,
                bcc = !string.IsNullOrEmpty(bcc) 
                    ? bcc.Split(';', StringSplitOptions.RemoveEmptyEntries)
                        .Select(e => new { email = e.Trim() }).ToArray() 
                    : null,
                templateId = templateId,
                @params = parameters
            };

            var jsonContent = JsonSerializer.Serialize(emailData, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            
            var response = await _httpClient.PostAsync($"{apiUrl}/smtp/email", content);
            
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                _logger.LogInformation("Email con template {TemplateId} enviado exitosamente a {Email} usando Brevo. Response: {Response}", 
                    templateId, email, responseContent);
                return new EmailResponse { StatusCode = HttpStatusCode.OK };
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogError("Error al enviar email con template {TemplateId} a {Email} usando Brevo. Status: {StatusCode}, Error: {Error}", 
                    templateId, email, response.StatusCode, errorContent);
                return new EmailResponse { StatusCode = response.StatusCode };
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error inesperado al enviar email con template {TemplateId} a {Email} usando Brevo", 
                templateId, email);
            return new EmailResponse { StatusCode = HttpStatusCode.InternalServerError };
        }
    }

    /// <summary>
    /// Formatea el mensaje de texto a HTML básico compatible con Brevo
    /// </summary>
    private string FormatHtmlMessage(string message)
    {
        if (string.IsNullOrEmpty(message))
            return string.Empty;

        // Convertir saltos de línea a HTML
        var htmlMessage = message.Replace("\n", "<br>");
        
        // Envolver en estructura HTML básica optimizada para Brevo
        return $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>{appName}</title>
    <style>
        body {{ font-family: Arial, sans-serif; line-height: 1.6; color: #333; margin: 0; padding: 0; }}
        .container {{ max-width: 600px; margin: 0 auto; padding: 20px; background-color: #ffffff; }}
        .footer {{ color: #666; font-size: 12px; margin-top: 30px; padding-top: 20px; border-top: 1px solid #eee; }}
    </style>
</head>
<body>
    <div class='container'>
        {htmlMessage}
        <div class='footer'>
            <p>Este email fue enviado por {appName}</p>
        </div>
    </div>
</body>
</html>";
    }
}