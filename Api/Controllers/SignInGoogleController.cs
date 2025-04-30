using Google.Apis.Auth;


namespace Places.Api.Controllers;
[Route("signin-google")]
[ApiController]
public class SignInGoogleController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IAuthenticationService _authenticationService;

    public SignInGoogleController(
    IUserRepository userRepository,
    IAuthenticationService authenticationService,
    IConfiguration configuration
    )
    {
        _userRepository = userRepository;
        _authenticationService = authenticationService;
        this.configuration = configuration;
    }
    private readonly IConfiguration configuration;

    public class GoogleCredentialDto
    {
        public string Credential { get; set; }
    }


    [HttpPost("login")]
    public async Task<IActionResult> LoginWithGoogle([FromBody] GoogleCredentialDto dto)
    {
        try
        {
            var settings = new GoogleJsonWebSignature.ValidationSettings()
            {
                Audience = new[] { configuration["AuthenticatonProviders:GoogleClientId"] ?? string.Empty }
            };

            var payload = await GoogleJsonWebSignature.ValidateAsync(dto.Credential, settings);
            if (payload == null)
            {
                return BadRequest("Token de Google no válido.");
            }

            var user = await _userRepository.FindByEmailAsync(payload.Email);

            if (user == null)
            {
                var newUser = new User
                {
                    Email = payload.Email,
                    FirstName = payload.GivenName,
                    LastName = payload.FamilyName ?? " ",
                    RoleId = 2,
                    CountryId = 80,
                    UserTypeId = 2,
                    ProfilePicture = payload.Picture,

                    // Campos mínimos necesarios
                    Salt = "temporalSalt",
                    HashedPassword = "temporalHash",
                    PlatformId = "platform-x",
                    Telephone = "00000000",
                    EmailCodeValidation = "0000",
                    TelephoneCodeValidation = "0000"
                };


                user = await _userRepository.AddAsync(newUser);
            }

            var token = _authenticationService.GenerateJwtToken(user);

            return Ok(new { token = token });
        }
        catch (Exception ex)
        {
            return BadRequest($"Error: {ex.Message}");
        }
    }

}
