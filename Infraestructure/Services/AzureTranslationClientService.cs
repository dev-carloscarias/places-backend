using Microsoft.Extensions.Configuration;
using System.Text;
using System.Text.Json;

namespace Places.Infrastructure.Services;

public class AzureTranslationClientService : IAzureTranslationClientService
{
    private readonly HttpClient _httpClient;

    private readonly string _subscriptionKey;

    private readonly string _endpoint;

    private readonly string _region;

    public AzureTranslationClientService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _subscriptionKey = configuration["AzureTranslationSettings:SubscriptionKey"];
        _endpoint = configuration["AzureTranslationSettings:Endpoint"];
        _region = configuration["AzureTranslationSettings:Region"];
    }

    public async Task<string> TranslateAsync(string sourceLanguage, string targetLanguage, string text)
    {
        var requestBody = JsonSerializer.Serialize(new[] { new { Text = text } });
        using var requestMessage = new HttpRequestMessage(HttpMethod.Post, $"{_endpoint}/translate?api-version=3.0&from={sourceLanguage}&to={targetLanguage}")
        {
            Content = new StringContent(requestBody, Encoding.UTF8, "application/json")
        };
        requestMessage.Headers.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);
        requestMessage.Headers.Add("Ocp-Apim-Subscription-Region", _region);

        var response = await _httpClient.SendAsync(requestMessage);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<JsonElement[]>(responseBody);
        if (result != null && result.Length > 0)
            return result[0].GetProperty("translations")[0].GetProperty("text").GetString();

        return string.Empty;
    }
}