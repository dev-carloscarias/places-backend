namespace Places.Application.Interfaces;

public interface IEmailService
{
    Task<EmailResponse> SendWelcomeEmailAsync(User user, string cc, string bcc);

    Task<EmailResponse> SendVerificationEmailAsync(User user, string cc, string bcc);

    Task<EmailResponse> SendOwnerRegistrationRequest(User user, string message);

    Task<EmailResponse> SendOwnerRegistrationResult(User user, string message);

    Task<EmailResponse> SendSiteRegistrationResult(User user, string message);
    Task<EmailResponse> SendCodeVerificationResult(string mail, string message);

}