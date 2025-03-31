namespace Places.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ScreensController : ControllerBase
{
    private readonly IScreenService _screenService;

    private readonly ISmsService _smsService;

    private readonly IMapper _mapper;

    public ScreensController(IScreenService screenService, IMapper mapper, ISmsService smsService)
    {
        _screenService = screenService;
        _mapper = mapper;
        _smsService = smsService;
    }

    // GET: api/Countries
    [HttpGet]
    [Route("GetByCode")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ScreenDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAll(string screen_code)
    {
        var itemsResult = await _screenService.GetByCode(screen_code);
        return Ok(_mapper.Map<ScreenDto>(itemsResult));
    }

    [HttpPost]
    [Route("Migration")]
    public async Task<IActionResult> Migrate()
    {
        //await _emailService.SendWelcomeEmailAsync("stevelopezc@gmail.com", "", "");

        //_smsService.SendMessage("This is a test from ", "+50240264326");
        //if (await _screenService.Any()) return BadRequest("Ya fue ejecutado");

        var list = new List<Screen>()
        {
            new Screen
            {
                ScreenCode = "site_register_pricing",
                Labels = new List<Label>() {
                    new Label { LabelCode = "site_register_pricing_package_item_name_2", LabelValue = "Item name" },
                }
            }
        };

        foreach (var item in list)
        {
            if (!await _screenService.Any(d => d.ScreenCode == item.ScreenCode))
                await _screenService.Create(item);
            else
            {
                Screen screenSearched = await _screenService.GetByCode(item.ScreenCode);
                foreach (var newLabel in item.Labels)
                {
                    screenSearched.Labels.Add(newLabel);
                }
                await _screenService.Edit(screenSearched);
            }
        }

        return Ok();
    }
}