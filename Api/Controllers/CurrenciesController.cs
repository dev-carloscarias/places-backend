using Places.Domain.Dtos;

namespace Places.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CurrenciesController : ControllerBase
{
    private readonly IMapper _mapper;

    private readonly ICurrencyService _currencyService;

    public CurrenciesController(IMapper mapper, ICurrencyService currencyService)
    {
        _mapper = mapper;
        _currencyService = currencyService;
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
        var queryResult = await _currencyService.GetAll();

        return Ok(_mapper.Map<List<CurrencyDto>>(queryResult));
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CurrencyDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromQuery] QueryRequest queryRequest)
    {
        List<Currency> itemsResult;

        if (queryRequest.SortOrder != null
           || queryRequest.CurrentFilter != null
           || queryRequest.SearchString != null
           || queryRequest.PageNumber != null
           || queryRequest.PageSize != null
           )
        {
            var queryResult = await _currencyService.GetByQueryRequestAsync(queryRequest);

            itemsResult = queryResult.Items;

            Response.Headers.Append("PaginationData", value: JsonConvert.SerializeObject(queryResult.PaginationData));

            return Ok(_mapper.Map<List<CurrencyDto>>(itemsResult));
        }

        itemsResult = (await _currencyService.GetAll() as List<Currency>)!;
        return Ok(_mapper.Map<List<Currency>>(itemsResult));
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CurrencyDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get(int id)
    {
        var itemResult = await _currencyService.GetById(id);
        return Ok(_mapper.Map<CurrencyDto>(itemResult));
    }

    // POST api/Users
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CurrencyDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Post([FromBody] CurrencyDto currencyDto)
    {
        var itemResult = await _currencyService.Create(_mapper.Map<CurrencyDto, Currency>(currencyDto)!);
        var resourceUrl = $"{Request.Path}/{itemResult.Id}";
        return Created(resourceUrl, _mapper.Map<CurrencyDto>(itemResult));
    }

    // PUT api/Users/5
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CurrencyDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Put([FromBody] CurrencyDto currencyDto)
    {
        var itemResult = await _currencyService.Edit(_mapper.Map<Currency>(currencyDto)!);
        return Ok(_mapper.Map<CurrencyDto>(itemResult));
    }

    // DELETE api/Users/5
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Delete(int id)
    {
        await _currencyService.Delete(id);
        return NoContent();
    }

    [HttpPost]
    [Route("Migration")]
    public async Task<IActionResult> Migrate()
    {
        if (await _currencyService.Any()) return BadRequest("Ya fue ejecutado");

        var list = new List<Currency>()
        {
            new Currency{Id=1, Name = "UAE Dirham", CurrencyCode="AED", Symbol="د.إ",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=2, Name = "Afghani", CurrencyCode="AFN", Symbol="Af",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=3, Name = "Lek", CurrencyCode="ALL", Symbol="L",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=4, Name = "Armenian Dram", CurrencyCode="AMD", Symbol="Դ",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=5, Name = "Kwanza", CurrencyCode="AOA", Symbol="Kz",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=6, Name = "Argentine Peso", CurrencyCode="ARS", Symbol="$", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=7, Name = "Australian Dollar", CurrencyCode="AUD", Symbol="$",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=8, Name = "Aruban Guilder/Florin", CurrencyCode="AWG", Symbol="ƒ",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=9, Name = "Azerbaijanian Manat", CurrencyCode="AZN", Symbol="ман",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=10, Name = "Konvertibilna Marka", CurrencyCode="BAM", Symbol="КМ",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=11, Name = "Barbados Dollar", CurrencyCode="BBD", Symbol="$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=12, Name = "Taka", CurrencyCode="BDT", Symbol="৳",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=13, Name = "Bulgarian Lev", CurrencyCode="BGN", Symbol="лв",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=14, Name = "Bahraini Dinar", CurrencyCode="BHD", Symbol="ب.د",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=15, Name = "Burundi Franc", CurrencyCode="BIF", Symbol="₣", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=16, Name = "Bermudian Dollar", CurrencyCode="BMD", Symbol="$",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=17, Name = "Brunei Dollar", CurrencyCode="BND", Symbol="$", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=18, Name = "Boliviano", CurrencyCode="BOB", Symbol="Bs.",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=19, Name = "Brazilian Real", CurrencyCode="BRL", Symbol="R$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=20, Name = "Bahamian Dollar", CurrencyCode="BSD", Symbol="$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=21, Name = "Ngultrum", CurrencyCode="BTN", Symbol="",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=22, Name = "Pula", CurrencyCode="BWP", Symbol="P",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=23, Name = "Belarusian Ruble", CurrencyCode="BYN", Symbol="Br", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=24, Name = "Belize Dollar", CurrencyCode="BZD", Symbol="$", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=25, Name = "Canadian Dollar", CurrencyCode="CAD", Symbol="$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=26, Name = "Congolese Franc", CurrencyCode="CDF", Symbol="₣",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=27, Name = "Swiss Franc", CurrencyCode="CHF", Symbol="₣",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=28, Name = "Chilean Peso", CurrencyCode="CLP", Symbol="$",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=29, Name = "Yuan", CurrencyCode="CNY", Symbol="¥",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=30, Name = "Colombian Peso", CurrencyCode="COP", Symbol="$",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=31, Name = "Costa Rican Colon", CurrencyCode="CRC", Symbol="₡", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=32, Name = "Cuban Peso", CurrencyCode="CUP", Symbol="$",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=33, Name = "Cape Verde Escudo", CurrencyCode="CVE", Symbol="$", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=34, Name = "Czech Koruna", CurrencyCode="CZK", Symbol="Kč", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=35, Name = "Djibouti Franc", CurrencyCode="DJF", Symbol="₣",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=36, Name = "Danish Krone", CurrencyCode="DKK", Symbol="kr", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=37, Name = "Dominican Peso", CurrencyCode="DOP", Symbol="$",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=38, Name = "Algerian Dinar", CurrencyCode="DZD", Symbol="د.ج",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=39, Name = "Egyptian Pound", CurrencyCode="EGP", Symbol="£",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=40, Name = "Nakfa", CurrencyCode="ERN", Symbol="Nfk",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=41, Name = "Ethiopian Birr", CurrencyCode="ETB", Symbol="", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=42, Name = "Euro", CurrencyCode="EUR", Symbol="€",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=43, Name = "Fiji Dollar", CurrencyCode="FJD", Symbol="$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=44, Name = "Falkland Islands Pound", CurrencyCode="FKP", Symbol="£",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=45, Name = "Pound Sterling", CurrencyCode="GBP", Symbol="£",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=46, Name = "Lari", CurrencyCode="GEL", Symbol="ლ",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=47, Name = "Cedi", CurrencyCode="GHS", Symbol="₵",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=48, Name = "Gibraltar Pound", CurrencyCode="GIP", Symbol="£",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=49, Name = "Dalasi", CurrencyCode="GMD", Symbol="D",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=50, Name = "Guinea Franc", CurrencyCode="GNF", Symbol="₣",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=51, Name = "Quetzal", CurrencyCode="GTQ", Symbol="Q",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=52, Name = "Guyana Dollar", CurrencyCode="GYD", Symbol="$", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=53, Name = "Hong Kong Dollar", CurrencyCode="HKD", Symbol="$",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=54, Name = "Lempira", CurrencyCode="HNL", Symbol="L",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=55, Name = "Croatian Kuna", CurrencyCode="HRK", Symbol="Kn",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=56, Name = "Gourde", CurrencyCode="HTG", Symbol="G",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=57, Name = "Forint", CurrencyCode="HUF", Symbol="Ft",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=58, Name = "Rupiah", CurrencyCode="IDR", Symbol="Rp",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=59, Name = "New Israeli Shekel", CurrencyCode="ILS", Symbol="₪",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=60, Name = "Indian Rupee", CurrencyCode="INR", Symbol="₹",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=61, Name = "Iraqi Dinar", CurrencyCode="IQD", Symbol="ع.د", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=62, Name = "Iranian Rial", CurrencyCode="IRR", Symbol="﷼",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=63, Name = "Iceland Krona", CurrencyCode="ISK", Symbol="Kr",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=64, Name = "Jamaican Dollar", CurrencyCode="JMD", Symbol="$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=65, Name = "Jordanian Dinar", CurrencyCode="JOD", Symbol="د.ا", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=66, Name = "Yen", CurrencyCode="JPY", Symbol="¥",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=67, Name = "Kenyan Shilling", CurrencyCode="KES", Symbol="Sh",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=68, Name = "Som", CurrencyCode="KGS", Symbol="",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=69, Name = "Riel", CurrencyCode="KHR", Symbol="៛",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=70, Name = "North Korean Won", CurrencyCode="KPW", Symbol="₩",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=71, Name = "South Korean Won", CurrencyCode="KRW", Symbol="₩",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=72, Name = "Kuwaiti Dinar", CurrencyCode="KWD", Symbol="د.ك",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=73, Name = "Cayman Islands Dollar", CurrencyCode="KYD", Symbol="$", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=74, Name = "Tenge", CurrencyCode="KZT", Symbol="〒", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=75, Name = "Kip", CurrencyCode="LAK", Symbol="₭",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=76, Name = "Lebanese Pound", CurrencyCode="LBP", Symbol="ل.ل",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=77, Name = "Sri Lanka Rupee", CurrencyCode="LKR", Symbol="Rs",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=78, Name = "Liberian Dollar", CurrencyCode="LRD", Symbol="$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=79, Name = "Loti", CurrencyCode="LSL", Symbol="L",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=80, Name = "Libyan Dinar", CurrencyCode="LYD", Symbol="ل.د",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=81, Name = "Moroccan Dirham", CurrencyCode="MAD", Symbol="د.م.",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=82, Name = "Moldovan Leu", CurrencyCode="MDL", Symbol="L",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=83, Name = "Malagasy Ariary", CurrencyCode="MGA", Symbol="",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=84, Name = "Denar", CurrencyCode="MKD", Symbol="ден",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=85, Name = "Kyat", CurrencyCode="MMK", Symbol="K",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=86, Name = "Tugrik", CurrencyCode="MNT", Symbol="₮",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=87, Name = "Pataca", CurrencyCode="MOP", Symbol="P",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=88, Name = "Ouguiya", CurrencyCode="MRU", Symbol="UM",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=89, Name = "Mauritius Rupee", CurrencyCode="MUR", Symbol="₨",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=90, Name = "Rufiyaa", CurrencyCode="MVR", Symbol="ރ.",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=91, Name = "Kwacha", CurrencyCode="MWK", Symbol="MK",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=92, Name = "Mexican Peso", CurrencyCode="MXN", Symbol="$",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=93, Name = "Malaysian Ringgit", CurrencyCode="MYR", Symbol="RM",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=94, Name = "Metical", CurrencyCode="MZN", Symbol="MTn", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=95, Name = "Namibia Dollar", CurrencyCode="NAD", Symbol="$",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=96, Name = "Naira", CurrencyCode="NGN", Symbol="₦", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=97, Name = "Cordoba Oro", CurrencyCode="NIO", Symbol="C$",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=98, Name = "Norwegian Krone", CurrencyCode="NOK", Symbol="kr",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=99, Name = "Nepalese Rupee", CurrencyCode="NPR", Symbol="₨",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=100, Name = "New Zealand Dollar", CurrencyCode="NZD", Symbol="$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=101, Name = "Rial Omani", CurrencyCode="OMR", Symbol="ر.ع.",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=102, Name = "Balboa", CurrencyCode="PAB", Symbol="B/.", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=103, Name = "Nuevo Sol", CurrencyCode="PEN", Symbol="S/.",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=104, Name = "Kina", CurrencyCode="PGK", Symbol="K", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=105, Name = "Philippine Peso", CurrencyCode="PHP", Symbol="₱",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=106, Name = "Pakistan Rupee", CurrencyCode="PKR", Symbol="₨",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=107, Name = "PZloty", CurrencyCode="PLN", Symbol="zł",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=108, Name = "Guarani", CurrencyCode="PYG", Symbol="₲",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=109, Name = "Qatari Rial", CurrencyCode="QAR", Symbol="ر.ق",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=110, Name = "Leu", CurrencyCode="RON", Symbol="L",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=111, Name = "Serbian Dinar", CurrencyCode="RSD", Symbol="din",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=112, Name = "Russian Ruble", CurrencyCode="RUB", Symbol="р.",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=113, Name = "Rwanda Franc", CurrencyCode="RWF", Symbol="₣", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=114, Name = "Saudi Riyal", CurrencyCode="SAR", Symbol="ر.س",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=115, Name = "Solomon Islands Dollar", CurrencyCode="SBD", Symbol="$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=116, Name = "Seychelles Rupee", CurrencyCode="SCR", Symbol="₨", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=117, Name = "Sudanese Pound", CurrencyCode="SDG", Symbol="£",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=118, Name = "Swedish Krona", CurrencyCode="SEK", Symbol="kr",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=119, Name = "Singapore Dollar", CurrencyCode="SGD", Symbol="$", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=120, Name = "Saint Helena Pound", CurrencyCode="SHP", Symbol="£",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=121, Name = "Leone", CurrencyCode="SLL", Symbol="Le",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=122, Name = "Somali Shilling", CurrencyCode="SOS", Symbol="Sh", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=123, Name = "Suriname Dollar", CurrencyCode="SRD", Symbol="$",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=124, Name = "Dobra", CurrencyCode="STN", Symbol="Db",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=125, Name = "Syrian Pound", CurrencyCode="SYP", Symbol="ل.س",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=126, Name = "Lilangeni", CurrencyCode="SZL", Symbol="L",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=127, Name = "Baht", CurrencyCode="THB", Symbol="฿", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=128, Name = "Somoni", CurrencyCode="TJS", Symbol="ЅМ",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=129, Name = "Manat", CurrencyCode="TMT", Symbol="m",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=130, Name = "Tunisian Dinar", CurrencyCode="TND", Symbol="د.ت", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=131, Name = "Pa’anga", CurrencyCode="TOP", Symbol="T$", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=132, Name = "Turkish Lira", CurrencyCode="TRY", Symbol="₤", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=133, Name = "Trinidad and Tobago Dollar", CurrencyCode="TTD", Symbol="$",   Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=134, Name = "Taiwan Dollar", CurrencyCode="TWD", Symbol="$",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=135, Name = "Tanzanian Shilling", CurrencyCode="TZS", Symbol="Sh",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=136, Name = "Hryvnia", CurrencyCode="UAH", Symbol="₴",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=137, Name = "Uganda Shilling", CurrencyCode="UGX", Symbol="Sh", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=138, Name = "US Dollar", CurrencyCode="USD", Symbol="$",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=139, Name = "Peso Uruguayo", CurrencyCode="UYU", Symbol="$",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=140, Name = "Uzbekistan Sum", CurrencyCode="UZS", Symbol="",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=141, Name = "Bolivar Fuerte", CurrencyCode="VEF", Symbol="Bs F",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=142, Name = "Dong", CurrencyCode="VND", Symbol="₫", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=143, Name = "Vatu", CurrencyCode="VUV", Symbol="Vt",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=144, Name = "Tala", CurrencyCode="WST", Symbol="T", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=145, Name = "CFA Franc BCEAO", CurrencyCode="XAF", Symbol="₣",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=146, Name = "East Caribbean Dollar", CurrencyCode="XCD", Symbol="$",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=147, Name = "CFP Franc", CurrencyCode="XPF", Symbol="₣",    Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=148, Name = "Yemeni Rial", CurrencyCode="YER", Symbol="﷼",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=149, Name = "Rand", CurrencyCode="ZAR", Symbol="R", Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=150, Name = "Zambian Kwacha", CurrencyCode="ZMW", Symbol="ZK",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Currency{Id=151, Name = "Zimbabwe Dollar", CurrencyCode="ZWL", Symbol="$",  Rate=1, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now}
        };

        foreach (var item in list)
        {
            await _currencyService.Create(item);
        }

        return Ok();
    }
}