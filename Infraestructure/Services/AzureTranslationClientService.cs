using Microsoft.Extensions.Configuration;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace Places.Infrastructure.Services;

public class AzureTranslationClientService : IAzureTranslationClientService
{
    private readonly HttpClient _httpClient;

    private readonly string _subscriptionKey;

    private readonly string _endpoint;

    private readonly string _region;
    
    private readonly ILogger<AzureTranslationClientService> _logger;

    public AzureTranslationClientService(HttpClient httpClient, IConfiguration configuration, ILogger<AzureTranslationClientService> logger)
    {
        _httpClient = httpClient;
        _subscriptionKey = configuration["AzureTranslationSettings:SubscriptionKey"];
        _endpoint = configuration["AzureTranslationSettings:Endpoint"];
        _region = configuration["AzureTranslationSettings:Region"];
        _logger = logger;
    }

    public async Task<string> TranslateAsync(string sourceLanguage, string targetLanguage, string text)
    {
        try
        {
            var requestBody = JsonSerializer.Serialize(new[] { new { Text = text } });
            using var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{_endpoint}/translate?api-version=3.0&from={sourceLanguage}&to={targetLanguage}")
            {
                Content = new StringContent(requestBody, Encoding.UTF8, "application/json")
            };
            requestMessage.Headers.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);
            requestMessage.Headers.Add("Ocp-Apim-Subscription-Region", _region);

            var response = await _httpClient.SendAsync(requestMessage);
            
            // Si hay un error, registramos el problema pero no lanzamos excepción
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger.LogWarning("Error en la traducción. Código: {StatusCode}, Contenido: {ErrorContent}", 
                    response.StatusCode, errorContent);
                
                // Devolvemos el texto original en caso de error
                return text;
            }

            var responseBody = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<JsonElement[]>(responseBody);
            if (result != null && result.Length > 0)
                return result[0].GetProperty("translations")[0].GetProperty("text").GetString();

            return text; // Devolvemos el texto original si no podemos traducir
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al intentar traducir texto de {SourceLanguage} a {TargetLanguage}", 
                sourceLanguage, targetLanguage);
            
            // Devolvemos el texto original en caso de excepción
            return text;
        }
    }
}