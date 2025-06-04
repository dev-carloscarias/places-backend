using System.Text.Json.Serialization;

namespace Places.Infrastructure.Services;

/// <summary>
/// Modelos para la respuesta de la API de Brevo
/// </summary>
public class BrevoResponse
{
    [JsonPropertyName("messageId")]
    public string? MessageId { get; set; }
}

/// <summary>
/// Modelo para errores de la API de Brevo
/// </summary>
public class BrevoErrorResponse
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public object? Details { get; set; }
}

/// <summary>
/// Modelo para el envío de email con contenido HTML
/// </summary>
public class BrevoEmailRequest
{
    [JsonPropertyName("sender")]
    public BrevoSender Sender { get; set; } = new();

    [JsonPropertyName("to")]
    public BrevoRecipient[] To { get; set; } = Array.Empty<BrevoRecipient>();

    [JsonPropertyName("cc")]
    public BrevoRecipient[]? Cc { get; set; }

    [JsonPropertyName("bcc")]
    public BrevoRecipient[]? Bcc { get; set; }

    [JsonPropertyName("subject")]
    public string Subject { get; set; } = string.Empty;

    [JsonPropertyName("htmlContent")]
    public string? HtmlContent { get; set; }

    [JsonPropertyName("textContent")]
    public string? TextContent { get; set; }

    [JsonPropertyName("tags")]
    public string[]? Tags { get; set; }
}

/// <summary>
/// Modelo para el envío de email con template
/// </summary>
public class BrevoTemplateEmailRequest
{
    [JsonPropertyName("sender")]
    public BrevoSender Sender { get; set; } = new();

    [JsonPropertyName("to")]
    public BrevoRecipient[] To { get; set; } = Array.Empty<BrevoRecipient>();

    [JsonPropertyName("cc")]
    public BrevoRecipient[]? Cc { get; set; }

    [JsonPropertyName("bcc")]
    public BrevoRecipient[]? Bcc { get; set; }

    [JsonPropertyName("templateId")]
    public int TemplateId { get; set; }

    [JsonPropertyName("params")]
    public Dictionary<string, object>? Params { get; set; }

    [JsonPropertyName("tags")]
    public string[]? Tags { get; set; }
}

/// <summary>
/// Modelo para el remitente
/// </summary>
public class BrevoSender
{
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

/// <summary>
/// Modelo para destinatarios
/// </summary>
public class BrevoRecipient
{
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Constantes para los códigos de estado de Brevo
/// </summary>
public static class BrevoStatusCodes
{
    public const string SUCCESS = "success";
    public const string INVALID_EMAIL = "invalid_email";
    public const string INVALID_SENDER = "invalid_sender";
    public const string TEMPLATE_NOT_FOUND = "template_not_found";
    public const string UNAUTHORIZED = "unauthorized";
    public const string QUOTA_EXCEEDED = "quota_exceeded";
}

/// <summary>
/// Extensiones para mejorar el manejo de respuestas de Brevo
/// </summary>
public static class BrevoExtensions
{
    public static bool IsSuccess(this System.Net.HttpStatusCode statusCode)
    {
        return (int)statusCode >= 200 && (int)statusCode < 300;
    }

    public static string GetBrevoErrorMessage(this BrevoErrorResponse error)
    {
        return error?.Message ?? "Error desconocido de Brevo";
    }
} 