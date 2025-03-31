namespace Places.Application.Services;

public class TranslationService : ITranslationService
{
    private readonly IAzureTranslationClientService _azureTranslationClient;

    public TranslationService(IAzureTranslationClientService azureTranslationClient)
    {
        _azureTranslationClient = azureTranslationClient;
    }

    public async Task<TranslationResponse> TranslateTextAsync(TranslationRequest request)
    {
        var translatedText = await _azureTranslationClient.TranslateAsync(request.SourceLanguage, request.TargetLanguage, request.Text);
        return new TranslationResponse { TranslatedText = translatedText };
    }
}