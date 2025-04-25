namespace Places.Application.Dtos;

public class OwnerRegistrationDto
{
    public int UserId { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Telephone { get; set; }
    public List<DataFileDto> DataFiles { get; set; } = [];
}