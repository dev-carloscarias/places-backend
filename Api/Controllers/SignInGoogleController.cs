using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Places.Api.Controllers;

[Route("signin-google")]
[ApiController]
public class SignInGoogleController : ControllerBase
{
    public SignInGoogleController(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    private const string callbackScheme = "myapp";

    private readonly IConfiguration configuration;

    [HttpGet]
    public async Task Get()
    {
        var kvp = HttpContext.Request.Query.FirstOrDefault(d => d.Key == "code");

        GoogleRequestToken requestToken = new GoogleRequestToken
        {
            ClientId = configuration["AuthenticatonProviders:GoogleClientId"] ?? string.Empty,
            ClientSecret = configuration["AuthenticatonProviders:GoogleClientSecret"] ?? string.Empty,
            Code = kvp.Value,
            GrantType = "authorization_code",
            RedirectUri = $"{Request.Scheme}://{Request.Host}/signin-google"
        };

        var request = JsonConvert.SerializeObject(requestToken);
        var content = new StringContent(
            request,
            Encoding.UTF8,
            "application/json");

        HttpClient client = new HttpClient();
        client.BaseAddress = new System.Uri("https://oauth2.googleapis.com");
        var response = await client.PostAsync($"token", content);
        string data = await response.Content.ReadAsStringAsync();

        GoogleToken googleToken = JsonConvert.DeserializeObject<GoogleToken>(data);

        client = new HttpClient();
        client.BaseAddress = new System.Uri("https://www.googleapis.com/oauth2/v2/userinfo");
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(googleToken.TokenType, googleToken.AccessToken);
        response = await client.GetAsync("");
        data = await response.Content.ReadAsStringAsync();

        GoogleData googleData = JsonConvert.DeserializeObject<GoogleData>(data);

        ProviderResponseDto providerResponse = new ProviderResponseDto
        {
            Id = googleData.Id,
            Name = googleData.Name,
            Email = googleData.Email,
            Picture = googleData.Picture,
            Provider = UserTypeId.Google
        };

        // Build the result url
        var url = callbackScheme + "://#" + string.Join(
            "&",
            $"data={WebUtility.UrlEncode(JsonConvert.SerializeObject(providerResponse))}"
            );

        // Redirect to final url
        Request.HttpContext.Response.Redirect(url);
    }
}