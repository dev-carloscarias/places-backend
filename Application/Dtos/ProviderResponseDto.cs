namespace Places.Application.Dtos;

public class ProviderResponseDto
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Picture { get; set; } = string.Empty;

    public UserTypeId Provider { get; set; }
}