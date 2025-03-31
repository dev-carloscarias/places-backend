namespace Places.Application.Dtos;

public class ChangePasswordDto
{
    public int UserId { get; set; }

    public string CurrentPassword { get; set; } = null!;

    public string Password { get; set; } = string.Empty;
}