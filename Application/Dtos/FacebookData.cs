namespace Places.Application.Dtos;

public class FacebookDebugTokenData
{
    public string app_id { get; set; }
    public string type { get; set; }
    public string application { get; set; }
    public long data_access_expires_at { get; set; }
    public long expires_at { get; set; }
    public bool is_valid { get; set; }
    public List<string> scopes { get; set; }
    public string user_id { get; set; }
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

public class FacebookCredentialDto
{
    public string accessToken { get; set; }
}

public class FacebookDebugTokenResponse
{
    public FacebookDebugTokenData data { get; set; }
}

public class FacebookUserInfo
{
    public string id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public Picture picture { get; set; }

    public class Picture
    {
        public PictureData data { get; set; }
    }

    public class PictureData
    {
        public string url { get; set; }
        public bool is_silhouette { get; set; }
    }
}
