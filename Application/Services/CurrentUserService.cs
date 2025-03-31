using Microsoft.AspNetCore.Http;

namespace Places.Application.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly HttpContext _httpContext;

    private readonly IUserRepository _userRepository;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor, IUserRepository userRepository)
    {
        _httpContext = httpContextAccessor.HttpContext;
        _userRepository = userRepository;
    }

    public async Task<User?> GetCurrentUserIdAsync()
    {
        if (_httpContext is null)
            return null;

        string userName = _httpContext.User.Identity?.Name ?? string.Empty;
        return await _userRepository.FindByEmailAsync(userName);
    }
}