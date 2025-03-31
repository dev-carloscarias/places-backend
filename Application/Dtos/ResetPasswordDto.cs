namespace Places.Application.Dtos;

public class ResetPasswordDto
{
    public int UserId { get; set; }

    public string Password { get; set; } = string.Empty;
}