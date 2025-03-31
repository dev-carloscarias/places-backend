namespace Places.Application.Interfaces;

public interface IAzureTranslationClientService
{
    Task<string> TranslateAsync(string sourceLanguage, string targetLanguage, string text);
}