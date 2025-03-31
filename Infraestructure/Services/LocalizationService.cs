namespace Places.Infrastructure.Services;

public class LocalizationService : ILocalizationService
{
    public string GetLanguage()
    {
        return Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
    }
}