namespace Places.Application.Dtos;

public class RegisterDto
{
    public string Email { get; set; } = string.Empty;

    public string ProfilePicture { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public UserTypeId UserTypeId { get; set; }

    public string PlatformId { get; set; } = string.Empty;

    public RoleId RoleId { get; set; }

    public string Telephone { get; set; } = string.Empty;

    public string CountryId { get; set; } = string.Empty;
}