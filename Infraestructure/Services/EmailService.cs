using Microsoft.Extensions.Configuration;

using SendGrid;
using SendGrid.Helpers.Mail;

namespace Places.Infrastructure.Services;

public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;

    private readonly string appName = string.Empty;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
        appName = _configuration["AppSettings:AppName"] ?? string.Empty;
    }

    public async Task<EmailResponse> SendWelcomeEmailAsync(User user, string cc, string bcc)
    {
        var data = new
        {
            verification_message = Resource.EmailVerificationMessage,
            verification_title = Resource.EmailVerificationTitle,
            code_instructions = Resource.EmailVerificationInstructions,
            code = user.EmailCodeValidation,
            verification_thanks = string.Format(Resource.EmailVerificationThanks, appName)
        };

        return await SendEmailAsync(user.Email, "d-8f82519a21294c33b017dca59387f2cf", data, cc, bcc);
    }

    public async Task<EmailResponse> SendVerificationEmailAsync(User user, string cc, string bcc)
    {
        var data = new { wellcome = Resource.email_welcome_subject, wellcome_message = Resource.email_welcome_message };

        return await SendEmailAsync(user.Email, "d-8019b25c8fb240cda80570a89eb01a30", data, cc, bcc);
    }

    public async Task<EmailResponse> SendOwnerRegistrationRequest(User user, string message)
    {
        return await SendEmailAsync(user.Email, "Solicitud de Propietario", message);
    }

    public async Task<EmailResponse> SendOwnerRegistrationResult(User user, string message)
    {
        return await SendEmailAsync(user.Email, "Resolucion de Registro de Propietario", message);
    }

    public async Task<EmailResponse> SendSiteRegistrationResult(User user, string message)
    {
        return await SendEmailAsync(user.Email, "Resultado de Registro de Sitio", message);
    }

    public async Task<EmailResponse> SendCodeVerificationResult(string mail, string message)
    {
        return await SendEmailAsync(mail, "Codigo de Verificación", message);
    }

    private async Task<EmailResponse> SendEmailAsync(string email, string subject, string message)
    {
        return await SendEmailAsync(email, subject, message, "", "");
    }

    private async Task<EmailResponse> SendEmailAsync(string email, string subject, string message, string cc = "", string bcc = "")
    {
        if (string.IsNullOrEmpty(email))
            return new EmailResponse { StatusCode = System.Net.HttpStatusCode.NoContent };

        var client = new SendGridClient(_configuration["SendGridConnectionStrings:SendGridKey"]);
        var from = new EmailAddress(_configuration["SendGridConnectionStrings:SendGridUser"], "Places");

        var addressTo = email.Split(';').Select(d => new EmailAddress(d)).ToList();

        var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, addressTo, subject, message, message);
        if (!string.IsNullOrEmpty(cc))
            msg.AddCcs(cc.Split(';').Select(d => new EmailAddress(d)).ToList());

        if (!string.IsNullOrEmpty(bcc))
            msg.AddBccs(bcc.Split(';').Select(d => new EmailAddress(d)).ToList());

        var response = await client.SendEmailAsync(msg);
        return new EmailResponse { StatusCode = response.StatusCode };
    }

    private async Task<EmailResponse> SendEmailAsync(string email, string templateId, object data, string cc = "", string bcc = "")
    {
        var client = new SendGridClient(_configuration["SendGridConnectionStrings:SendGridKey"]);
        var from = new EmailAddress(_configuration["SendGridConnectionStrings:SendGridUser"], "Places");

        var msg = MailHelper.CreateSingleTemplateEmail(from, new EmailAddress(email), templateId, data);

        if (!string.IsNullOrEmpty(cc))
            msg.AddCcs(cc.Split(';').Select(d => new EmailAddress(d)).ToList());

        if (!string.IsNullOrEmpty(bcc))
            msg.AddBccs(bcc.Split(';').Select(d => new EmailAddress(d)).ToList());

        var response = await client.SendEmailAsync(msg);
        return new EmailResponse { StatusCode = response.StatusCode };
    }
}