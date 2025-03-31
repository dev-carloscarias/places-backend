using System.Diagnostics;

namespace Places.Api.Controllers;

[Route("signin-facebook")]
[ApiController]
public class SignInController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public SignInController(IConfiguration configuration)
    {
        this._configuration = configuration;
    }

    private const string callbackScheme = "myapp";

    [HttpGet]
    public async Task Get()
    {
        var kvp = HttpContext.Request.Query.FirstOrDefault(d => d.Key == "code");

        HttpClient client = new HttpClient();
        client.BaseAddress = new System.Uri("https://graph.facebook.com");
        var response = await client.GetAsync($"v3.2/oauth/access_token?client_id={_configuration["AuthenticatonProviders:FacebookAppId"]}&redirect_uri={Request.Scheme}://{Request.Host}/signin-facebook&client_secret={_configuration["AuthenticatonProviders:FacebookAppSecret"]}&code={kvp.Value}");
        string data = await response.Content.ReadAsStringAsync();

        FacebookToken facebookToken = JsonConvert.DeserializeObject<FacebookToken>(data);

        response = await client.GetAsync($"v15.0/me?access_token={facebookToken.AccessToken}&fields=id,name,first_name,last_name");
        data = await response.Content.ReadAsStringAsync();

        FacebookData facebookData = JsonConvert.DeserializeObject<FacebookData>(data);

        response = await client.GetAsync($"https://graph.facebook.com/{facebookData.Id}/picture?type=large&width=720&height=720&redirect=false");

        if (!response.IsSuccessStatusCode)
        {
            Debug.WriteLine($"Could not get FACEBOOK email. Status: {response.StatusCode}");
        }

        data = await response.Content.ReadAsStringAsync();
        facebookData.Picture = JsonConvert.DeserializeObject<Picture>(data);

        ProviderResponseDto providerResponse = new ProviderResponseDto
        {
            Id = facebookData.Id,
            Name = facebookData.Name,
            Email = facebookData.Email,
            Picture = facebookData.Picture?.Data?.Url ?? string.Empty,
            Provider = UserTypeId.Facebook
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