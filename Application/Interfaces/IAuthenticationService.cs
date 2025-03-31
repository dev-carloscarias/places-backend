namespace Places.Application.Interfaces;

public interface IAuthenticationService
{
    Task<string> Login(string email, string password);

    Task<User> Register(User user, string password);

    string GenerateJwtToken(User user);

    Task<string> ValidateCode(int id, string code);

    Task<bool> ChangePassword(int userId, string currentPassword, string password);

    Task<User> ResendConfirmation(string email);

    Task<bool> ResetPassword(int userId, string password);
}