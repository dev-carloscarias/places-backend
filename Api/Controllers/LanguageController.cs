namespace Places.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguageController : ControllerBase
{
    private readonly ILanguageService _languageService;

    private readonly IMapper _mapper;

    public LanguageController(ILanguageService languageService, IMapper mapper)
    {
        _languageService = languageService;
        _mapper = mapper;
    }

    [HttpGet("GetAll")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CurrencyDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get()
    {
        var queryResult = await _languageService.GetAll();

        return Ok(_mapper.Map<List<LanguageDto>>(queryResult));
    }

    [HttpPost]
    [Route("Migration")]
    public async Task<IActionResult> Migrate()
    {
        if (await _languageService.Any()) return BadRequest("Ya fue ejecutado");

        var list = new List<Language>()
        {
            new Language{ Id =1, Name = "English", LanguageCode="en",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =2, Name = "Spanish", LanguageCode="es",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =3, Name = "French", LanguageCode="fr",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =4, Name = "Italian", LanguageCode="it",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =5, Name = "Portuguese", LanguageCode="pt",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =6, Name = "German", LanguageCode="de",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =7, Name = "Bulgarian", LanguageCode="bg", CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =8, Name = "Japanese", LanguageCode="ja",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =9, Name = "Korean", LanguageCode="ko",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =10, Name = "Chinese", LanguageCode="zh",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =11, Name = "Azerbaijani", LanguageCode="az",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =12, Name = "Indonesian", LanguageCode="id",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =13, Name = "Bosnian", LanguageCode="bs",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =14, Name = "Catalan", LanguageCode="ca",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =15, Name = "Czech", LanguageCode="cs",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =16, Name = "Danish", LanguageCode="da",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =17, Name = "Croatian", LanguageCode="hr", CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =18, Name = "Icelandic", LanguageCode="is",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =19, Name = "Kiswahili", LanguageCode="sw",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =20, Name = "Latvian", LanguageCode="lv",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =21, Name = "Lithuanian", LanguageCode="lt",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =22, Name = "Maltese", LanguageCode="mt",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =23, Name = "Malay", LanguageCode="ms",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =24, Name = "Russian", LanguageCode="ru",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =25, Name = "Romanian", LanguageCode="ro", CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =26, Name = "Filipinian", LanguageCode="fil",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =27, Name = "Swedish", LanguageCode="sv",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =28, Name = "Vietnamese", LanguageCode="vi",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =29, Name = "Turkish", LanguageCode="tr",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =30, Name = "Arabic", LanguageCode="ar",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =31, Name = "Irish", LanguageCode="ga",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =32, Name = "isiXhosa", LanguageCode="xh", CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =33, Name = "isiZulu", LanguageCode="zu",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =34, Name = "Hungarian", LanguageCode="hu",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =35, Name = "Dutch", LanguageCode="nl",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =36, Name = "Norwegian", LanguageCode="no",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =37, Name = "Polish", LanguageCode="pl",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =38, Name = "Albanian", LanguageCode="sq", CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =39, Name = "Slovak", LanguageCode="sk",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =40, Name = "Slovenian", LanguageCode="sl",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =41, Name = "Serbian", LanguageCode="sr",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =42, Name = "Finnish", LanguageCode="fi",  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =43, Name = "Greek", LanguageCode="el",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =44, Name = "Macedonian", LanguageCode="mk",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =45, Name = "Ukrainian", LanguageCode="uk",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =46, Name = "Georgian", LanguageCode="ka", CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =47, Name = "Armenian", LanguageCode="hy", CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =48, Name = "Hebrew", LanguageCode="he",   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =49, Name = "Hindi", LanguageCode="hi",    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Language{ Id =50, Name = "Thai", LanguageCode="th", CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
        };

        foreach (var item in list)
        {
            item.IsActive = true;
            await _languageService.Create(item);
        }

        return Ok();
    }
}