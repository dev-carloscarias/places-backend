using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Places.Api.Controllers
{
    [Route("signin-facebook")]
    [ApiController]
    public class SignInController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IAuthenticationService _authenticationService;

        public SignInController(
            IConfiguration configuration,
            IUserRepository userRepository,
            IAuthenticationService authenticationService
        )
        {
            _configuration = configuration;
            _userRepository = userRepository;
            _authenticationService = authenticationService;
        }


        [HttpPost("login")]
        public async Task<IActionResult> LoginWithFacebook([FromBody] FacebookCredentialDto dbo)
        {
            var httpClient = new HttpClient();

            var appId = _configuration["AuthenticatonProviders:FacebookAppId"] ?? string.Empty;
            var appSecret = _configuration["AuthenticatonProviders:FacebookAppSecret"] ?? string.Empty;
            string appAccessToken = $"{appId}|{appSecret}";

            // Validar el token
            var tokenValidationUrl =
                $"https://graph.facebook.com/debug_token?input_token={dbo.accessToken}&access_token={appAccessToken}";
            var response = await httpClient.GetAsync(tokenValidationUrl);

            if (!response.IsSuccessStatusCode)
                return Unauthorized("Error al validar token");

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<FacebookDebugTokenResponse>(content);

            if (result?.data?.is_valid != true)
                return Unauthorized("Token inválido");

            // Obtener información del usuario
            var userInfoUrl =
                $"https://graph.facebook.com/me?fields=id,name,email,picture&access_token={dbo.accessToken}";
            var userInfoResponse = await httpClient.GetAsync(userInfoUrl);

            if (!userInfoResponse.IsSuccessStatusCode)
                return Unauthorized("No se pudo obtener información del usuario");

            var userContent = await userInfoResponse.Content.ReadAsStringAsync();
            var userData = JsonConvert.DeserializeObject<FacebookUserInfo>(userContent);

            if (string.IsNullOrEmpty(userData.email))
                return BadRequest("El usuario no compartió su correo electrónico");

            // Aquí podés guardar al usuario o generar un JWT si querés
            var separarNombre = SepararNombre(userData.name);


            var user = await _userRepository.FindByEmailAsync(userData.email);
            if (user == null)
            {
                var newUser = new User
                {
                    Email = userData.email,
                    FirstName = separarNombre.FirstName,
                    LastName = separarNombre.LastName,
                    RoleId = 2,
                    CountryId = 80,
                    UserTypeId = 2,
                    ProfilePicture = userData.picture.data.url,

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

        public class SeparateName
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        private SeparateName SepararNombre(string nombreCompleto)
        {
            if (string.IsNullOrWhiteSpace(nombreCompleto))
                return new SeparateName { FirstName = "", LastName = "" };

            var partes = nombreCompleto.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (partes.Length == 1)
            {
                return new SeparateName
                {
                    FirstName = partes[0],
                    LastName = ""
                };
            }

            return new SeparateName
            {
                FirstName = partes[0],
                LastName = string.Join(" ", partes.Skip(1))
            };
        }


    }

}
