namespace Places.Application.Dtos;

public class FacebookData
{
    [JsonProperty("id")]
    public string Id { get; set; } = string.Empty;

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("email")]
    public string Email { get; set; } = string.Empty;

    [JsonProperty("first_name")]
    public string FirstName { get; set; } = string.Empty;

    [JsonProperty("last_name")]
    public string LastName { get; set; } = string.Empty;

    [JsonProperty("picture")]
    public Picture Picture { get; set; } = null!;
}

public class Picture
{
    [JsonProperty("data")]
    public Data Data { get; set; } = null!;
}

public class Data
{
    [JsonProperty("height")]
    public int Height { get; set; }

    [JsonProperty("is_silhouette")]
    public bool IsSilhouette { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty;

    [JsonProperty("width")]
    public int Width { get; set; }
}

public class FacebookToken
{
    [JsonProperty("access_token")]
    public string AccessToken { get; set; } = string.Empty;

    [JsonProperty("token_type")]
    public string TokenType { get; set; } = string.Empty;

    [JsonProperty("expires_in")]
    public int ExpiresIn { get; set; }
}