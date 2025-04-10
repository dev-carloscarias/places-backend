using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Places.Application.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _userRepository;

    private readonly IConfiguration _configuration;

    private readonly ISmsService _smsService;

    private readonly IEmailService _emailService;

    public AuthenticationService(
        IUserRepository userRepository,
        IConfiguration configuration,
        ISmsService smsService,
        IEmailService emailService)
    {
        _userRepository = userRepository;
        _configuration = configuration;
        _smsService = smsService;
        _emailService = emailService;
    }

    public string GenerateJwtToken(User user)
    {
        var secretKey = _configuration["JwtBearer:SecretKey"];
        var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey!));
        var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
        var header = new JwtHeader(signingCredentials);

        var claims = new List<Claim>
        {
            new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new (JwtRegisteredClaimNames.NameId, user.Id.ToString()),
            new (JwtRegisteredClaimNames.Email, user.Email),
            new (ClaimTypes.Name, user.Email),
            new ("name", $"{user.FirstName} {user.LastName}"),
            new ("countryId", user.CountryId.ToString()),
            new ("roleId", user.RoleId.ToString())
        };

        var payload = new JwtPayload(
            issuer: _configuration["JwtBearer:Issuer"],
            audience: _configuration["JwtBearer:Audience"],
            claims: claims,
            notBefore: DateTime.Now,
            expires: DateTime.UtcNow.AddHours(24));

        var token = new JwtSecurityToken(header, payload);
        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

        return jwtSecurityTokenHandler.WriteToken(token);
    }

    public async Task<string> Login(string email, string password)
    {
        var user = await _userRepository.FindByEmailAsync(email);
        var token = string.Empty;
        if (user != null && VerifyPassword(user, password))
        {
            if (!user.HasEmailValidated && !user.HasTelephoneValidated && user.RoleId == (int)RoleId.RegularUser)
                throw new BadRequestException(LanguageConst.InvalidUserValidation);

            token = GenerateJwtToken(user);
            return token;
        }

        return token;
    }

    public async Task<User> Register(User user, string password)
    {
        var userExists = await _userRepository.FindByEmailAsync(user.Email);
        if (userExists != null)
        {
            throw new BadRequestException(LanguageConst.EmailAlreadyExists);
        }

        string salt = GenerateSalt();
        string hashedPassword = GenerateHashedPassword(password, salt);

        user.EmailCodeValidation = RandomNumberGenerator.GetInt32(1, 999999).ToString();
        user.TelephoneCodeValidation = RandomNumberGenerator.GetInt32(1, 999999).ToString();

        var newUser = new User
        {
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            HashedPassword = hashedPassword,
            Salt = salt,
            RegistrationDate = DateTime.UtcNow,
            IsActive = true,
            MustChangePassword = false,
            RoleId = user.RoleId,
            CountryId = user.CountryId,
            HasProperties = user.HasProperties,
            PlatformId = user.PlatformId,
            UserTypeId = user.UserTypeId,
            EmailCodeValidation = GenerateHashedPassword(user.EmailCodeValidation, salt),
            TelephoneCodeValidation = GenerateHashedPassword(user.TelephoneCodeValidation, salt),
            HasEmailValidated = false,
            HasTelephoneValidated = false,
            ProfilePicture = user.ProfilePicture,
            Telephone = user.Telephone
        };

        var createdUser = await _userRepository.AddAsync(newUser);

        user.Telephone = "40264326";

        user.Telephone = $"+{createdUser.Country.CountryCode}{user.Telephone}";

        await _emailService.SendWelcomeEmailAsync(user, string.Empty, string.Empty);
        await _emailService.SendCodeVerificationResult(user.Email, "Tu codigo de verificacion es: "+ user.TelephoneCodeValidation );
       //_smsService.SendVerificationMessage(user);

        return createdUser;
    }

    private static bool VerifyPassword(User user, string password)
    {
        return user.HashedPassword.Equals(GenerateHashedPassword(password, user.Salt));
    }

    public static string GenerateHashedPassword(string password, string salt)
    {
        var saltByteArray = Convert.FromBase64String(salt);

        string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: saltByteArray,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

        return hashedPassword;
    }

    public static string GenerateSalt(int saltLength = 16)
    {
        var salt = RandomNumberGenerator.GetBytes(saltLength);
        return Convert.ToBase64String(salt);
    }

    public async Task<string> ValidateCode(int id, string code)
    {
        bool isValid = false;
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null) return string.Empty;

        var hashCode = GenerateHashedPassword(code, user.Salt);

        if (user.EmailCodeValidation == hashCode)
        {
            user.HasEmailValidated = true;
            isValid = true;
        }
        else if (user.TelephoneCodeValidation == hashCode)
        {
            user.HasTelephoneValidated = true;
            isValid = true;
        }

        if (!isValid)
            throw new BadRequestException(LanguageConst.InvalidVerificationCode);

        await _userRepository.UpdateAsync(user);

        return GenerateJwtToken(user);
    }

    public async Task<bool> ChangePassword(int userId, string currentPassword, string password)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        if (user == null) return false;

        string hashedPassword = GenerateHashedPassword(currentPassword, user.Salt);

        if (hashedPassword != user.HashedPassword)
            throw new BadRequestException(LanguageConst.InvalidPassword);

        hashedPassword = GenerateHashedPassword(password, user.Salt);
        user.HashedPassword = hashedPassword;

        await _userRepository.UpdateAsync(user);

        return true;
    }

    public async Task<bool> ResetPassword(int userId, string password)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        if (user == null) return false;

        string hashedPassword = GenerateHashedPassword(password, user.Salt);
        user.HashedPassword = hashedPassword;

        await _userRepository.UpdateAsync(user);

        return true;
    }

    public async Task<User> ResendConfirmation(string email)
    {
        var user = await _userRepository.FindByEmailAsync(email);
        if (user == null) throw new BadRequestException(LanguageConst.InvalidEmail);

        user.EmailCodeValidation = RandomNumberGenerator.GetInt32(1, 999999).ToString();
        user.TelephoneCodeValidation = RandomNumberGenerator.GetInt32(1, 999999).ToString();

        user.Telephone = "40264326";

        user.Telephone = $"+502";

        await _emailService.SendWelcomeEmailAsync(user, string.Empty, string.Empty);
        _smsService.SendVerificationMessage(user);

        user.EmailCodeValidation = GenerateHashedPassword(user.EmailCodeValidation, user.Salt);
        user.TelephoneCodeValidation = GenerateHashedPassword(user.TelephoneCodeValidation, user.Salt);

        await _userRepository.UpdateAsync(user);

        return user;
    }
}