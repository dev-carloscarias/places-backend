namespace Places.Application.Interfaces;

public interface ICurrentUserService
{
    Task<User?> GetCurrentUserIdAsync();
}