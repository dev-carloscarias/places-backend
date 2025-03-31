namespace Places.Application.Dtos;

public class OwnerRegistrationDto
{
    public int UserId { get; set; }

    public List<DataFileDto> DataFiles { get; set; } = [];
}