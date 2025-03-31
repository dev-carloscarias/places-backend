namespace Places.Application.Dtos;

public class OwnerDetailRegistrationDto
{
    public int UserId { get; set; }

    public string Email { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Telephone { get; set; } = null!;

    public string ProfilePicture { get; set; } = null!;

    public List<DataFileDto> DataFiles { get; set; } = [];
}