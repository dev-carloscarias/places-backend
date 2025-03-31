namespace Places.Application.Dtos;

public class GoogleData
{
    [JsonProperty("id")]
    public string Id { get; set; } = string.Empty;

    [JsonProperty("email")]
    public string Email { get; set; } = string.Empty;

    [JsonProperty("verified_email")]
    public bool VerifiedEmail { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("given_name")]
    public string GivenName { get; set; } = string.Empty;

    [JsonProperty("family_name")]
    public string FamilyName { get; set; } = string.Empty;

    [JsonProperty("link")]
    public string Link { get; set; } = string.Empty;

    [JsonProperty("picture")]
    public string Picture { get; set; } = string.Empty;

    [JsonProperty("gender")]
    public string Gender { get; set; } = string.Empty;
}

public class GoogleToken
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; } = string.Empty;

    [JsonProperty("token_type")]
    public string TokenType { get; set; } = string.Empty;

    [JsonProperty("expires_in")]
    public int ExpiresIn { get; set; }

    [JsonProperty("id_token")]
    public string IdToken { get; set; } = string.Empty;
}

public class GoogleRequestToken
{
    [JsonProperty("code")]
    public string Code { get; set; } = string.Empty;

    [JsonProperty("client_id")]
    public string ClientId { get; set; } = string.Empty;

    [JsonProperty("client_secret")]
    public string ClientSecret { get; set; } = string.Empty;

    [JsonProperty("redirect_uri")]
    public string RedirectUri { get; set; } = string.Empty;

    [JsonProperty("grant_type")]
    public string GrantType { get; set; } = string.Empty;
}