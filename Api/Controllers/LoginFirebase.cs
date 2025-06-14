using System.IdentityModel.Tokens.Jwt;
using FirebaseAdmin.Auth;
using Google.Apis.Auth;
using Newtonsoft.Json.Linq;


namespace Places.Api.Controllers;
[Route("login-firebase")]
[ApiController]

    
public class LoginFirebase : ControllerBase
{
    private readonly IUserRepository _userRepository;
    private readonly IAuthenticationService _authenticationService;

    public LoginFirebase(
        IUserRepository userRepository,
        IAuthenticationService authenticationService
    ) {
        _userRepository = userRepository;
        _authenticationService = authenticationService;
    }
    public class LoginFirebaseDto
    {
        public string Credential { get; set; }
    }

    [HttpPost("login")]
    public async Task<IActionResult> loginWithFirebase([FromBody] LoginFirebaseDto dto)
    {
        try
        {
            // Verificar el token enviado desde Firebase
            FirebaseToken decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(dto.Credential);

            string email = decodedToken.Claims["email"]?.ToString() ?? string.Empty;
            string name = decodedToken.Claims["name"]?.ToString() ?? string.Empty;
            string picture = decodedToken.Claims["picture"]?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(email))
                return BadRequest("No se pudo extraer el email del token.");


            // Buscar usuario en base de datos
            var user = await _userRepository.FindByEmailAsync(email);

            if (user == null)
            {
                var nombres = name.Split(' ', 2);
                var newUser = new User
                {
                    Email = email,
                    FirstName = nombres.ElementAtOrDefault(0),
                    LastName = nombres.ElementAtOrDefault(1) ?? " ",
                    ProfilePicture = picture,
                    RoleId = 2,
                    CountryId = 80,
                    UserTypeId = 2,
                    Salt = "temporalSalt",
                    HashedPassword = "temporalHash",
                    PlatformId = "platform-x",
                    Telephone = "00000000",
                    EmailCodeValidation = "0000",
                    TelephoneCodeValidation = "0000"
                };

                user = await _userRepository.AddAsync(newUser);
            }

            // Generar JWT
            var jwtToken = _authenticationService.GenerateJwtToken(user);


            return Ok(new { token = jwtToken });
        }
        catch (FirebaseAuthException ex)
        {
            return BadRequest("Token Firebase inválido: " + ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Error interno: " + ex.Message);
        }

    }



}

