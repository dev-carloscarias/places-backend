using Microsoft.Extensions.Logging;

namespace Places.Application.Services;

public class TranslationService : ITranslationService
{
    private readonly IAzureTranslationClientService _azureTranslationClient;
    private readonly ILogger<TranslationService> _logger;

    public TranslationService(
        IAzureTranslationClientService azureTranslationClient,
        ILogger<TranslationService> logger)
    {
        _azureTranslationClient = azureTranslationClient;
        _logger = logger;
    }

    public async Task<TranslationResponse> TranslateTextAsync(TranslationRequest request)
    {
        try
        {
            var translatedText = await _azureTranslationClient.TranslateAsync(request.SourceLanguage, request.TargetLanguage, request.Text);
            
            // Si el texto traducido es igual al original, podemos asumir que hubo un problema o no se pudo traducir
            if (translatedText == request.Text && request.SourceLanguage != request.TargetLanguage)
            {
                _logger.LogWarning("La traducción devolvió el texto original. Posible problema con el servicio de traducción. De {Source} a {Target}", 
                    request.SourceLanguage, request.TargetLanguage);
            }
            
            return new TranslationResponse { TranslatedText = translatedText };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error en el servicio de traducción");
            // En caso de error, devolvemos el texto original
            return new TranslationResponse { TranslatedText = request.Text };
        }
    }
}