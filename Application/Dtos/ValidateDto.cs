namespace Places.Application.Dtos;

public class ValidateDto
{
    public int UserId { get; set; }

    public string CodeConfirmation { get; set; } = string.Empty;
}