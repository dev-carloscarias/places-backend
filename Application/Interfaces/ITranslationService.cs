namespace Places.Application.Interfaces;

public interface ITranslationService
{
    Task<TranslationResponse> TranslateTextAsync(TranslationRequest request);
}