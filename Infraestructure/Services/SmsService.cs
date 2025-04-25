using Microsoft.Extensions.Configuration;
using Places.Domain.Define;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Places.Infrastructure.Services;

public class SmsService : ISmsService
{
    private readonly IConfiguration _configuration;

    private readonly string fromTelephone = string.Empty;

    private readonly string appName = string.Empty;

    public SmsService(IConfiguration configuration)
    {
        _configuration = configuration;
        TwilioClient.Init(_configuration["TwilioConnectionStrings:AccountSid"], _configuration["TwilioConnectionStrings:Token"]);
        fromTelephone = _configuration["TwilioConnectionStrings:From"] ?? string.Empty;
        appName = _configuration["AppSettings:AppName"] ?? string.Empty;
    }

    public string SendVerificationMessage(User user)
    {
        try
        {
            return SendMessage($"{string.Format(LanguageConst.SMSVerificationMessage, appName)} {user.TelephoneCodeValidation}", $"{user.Telephone}");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
        }
        return string.Empty;
    }

    private string SendMessage(string messageBody, string toTelephone)
    {
        var message = MessageResource.Create(
            body: messageBody,
            from: new Twilio.Types.PhoneNumber(fromTelephone),
            to: new Twilio.Types.PhoneNumber(toTelephone)
        );

        return message.Sid;
    }
}