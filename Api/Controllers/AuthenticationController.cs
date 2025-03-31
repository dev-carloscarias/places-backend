namespace Places.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    private readonly ICountryService _countryService;

    private readonly IMapper _mapper;

    public AuthenticationController(IAuthenticationService userService, IMapper mapper, ICountryService countryService)
    {
        _authenticationService = userService;
        _mapper = mapper;
        _countryService = countryService;
    }

    // POST api/<ActosController>/login
    [HttpPost("login")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoginDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Login(LoginInputDto authenticationDto)
    {
        var token = await _authenticationService.Login(authenticationDto.Email, authenticationDto.Password);
        if (string.IsNullOrWhiteSpace(token))
        {
            return Unauthorized();
        }

        return Ok(new LoginDto { Token = token });
    }

    [HttpPost("register")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        var country = await _countryService.GetByIso2CodeAsync(registerDto.CountryId);

        if (country == null) return NoContent();

        registerDto.CountryId = country.Id.ToString();

        var user = _mapper.Map<User>(registerDto);

        var userDto = _mapper.Map<UserDto>(await _authenticationService.Register(user, registerDto.Password));

        return Ok(userDto);
    }

    [HttpPost("validate")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ValidateDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Validate(ValidateDto validateDto)
    {
        var token = await _authenticationService.ValidateCode(validateDto.UserId, validateDto.CodeConfirmation);
        return Ok(new { IsValid = true, Token = token });
    }

    [HttpPost("changePassword")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ChangePasswordDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ChangePassword(ChangePasswordDto changePassword)
    {
        var result = await _authenticationService.ChangePassword(changePassword.UserId, changePassword.CurrentPassword, changePassword.Password);
        return Ok(new { IsValid = result });
    }

    [HttpPost("changePasswordConfirmation")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ChangePasswordDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ChangePasswordConfirmation(ResetPasswordDto resetPassword)
    {
        var result = await _authenticationService.ResetPassword(resetPassword.UserId, resetPassword.Password);
        return Ok(new { IsValid = result });
    }

    [HttpPost("resendConfirmation")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResendCodeVerificationDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ResendConfirmation(ResendCodeVerificationDto resendCode)
    {
        var userDto = _mapper.Map<UserDto>(await _authenticationService.ResendConfirmation(resendCode.Email));
        return Ok(new { IsValid = true, User = userDto });
    }
}

/*
dotnet ef migrations add "NullableDateOfBirth" --project Infraestructure --startup-project API --output-dir Data\Migrations
dotnet ef database update --project Infraestructure --startup-project API
 */