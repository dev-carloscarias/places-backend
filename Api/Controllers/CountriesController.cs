using Places.Domain.Dtos;
using CountryData;
using CountryData.Standard;
namespace Places.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CountriesController : ControllerBase
{
    private readonly ICountryService _countryService;

    private readonly IMapper _mapper;
    private CountryHelper helper = new CountryHelper();

    public CountriesController(ICountryService countryService, IMapper mapper)
    {
        _countryService = countryService;
        _mapper = mapper;
    }

    // GET: api/Countries
    [HttpGet]
    [AllowAnonymous]
    [Route("GetAll")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CountryDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAll(int? continentId)
    {
        List<Domain.Entities.Country> itemsResult;

        itemsResult = (await _countryService.GetAllActive(continentId) as List<Domain.Entities.Country>)!;
        foreach (var country in itemsResult)
        {
            var countryFlag = helper.GetCountryEmojiFlag(country.Iso2.ToString().ToUpper());
            Console.WriteLine(countryFlag);
        }
        return Ok(_mapper.Map<List<CountryDto>>(itemsResult));
    }

    // GET: api/Countries
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CountryDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromQuery] QueryRequest queryRequest)
    {
        List<Domain.Entities.Country> itemsResult;

        if (queryRequest.SortOrder != null
           || queryRequest.CurrentFilter != null
           || queryRequest.SearchString != null
           || queryRequest.PageNumber != null
           || queryRequest.PageSize != null
           )
        {
            var queryResult = await _countryService.GetByQueryRequestAsync(queryRequest);

            itemsResult = queryResult.Items;

            Response.Headers.Append("PaginationData", value: JsonConvert.SerializeObject(queryResult.PaginationData));

            return Ok(_mapper.Map<List<CountryDto>>(itemsResult));
        }

        itemsResult = (await _countryService.GetAll() as List<Domain.Entities.Country>)!;
        return Ok(_mapper.Map<List<CountryDto>>(itemsResult));
    }

    // GET api/Countries/5
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CountryDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get(int id)
    {
        var itemResult = await _countryService.GetById(id);
        return Ok(_mapper.Map<CountryDto>(itemResult));
    }

    // POST api/Countries
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CountryDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Post([FromBody] CountryDto countryDto)
    {
        var itemResult = await _countryService.Create(_mapper.Map<CountryDto, Domain.Entities.Country>(countryDto)!);
        var resourceUrl = $"{Request.Path}/{itemResult.Id}";
        return Created(resourceUrl, _mapper.Map<CountryDto>(itemResult));
    }

    // PUT api/Countries/5
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CountryDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Put([FromBody] CountryDto countryDto)
    {
        var itemResult = await _countryService.Edit(_mapper.Map<Domain.Entities.Country>(countryDto)!);
        return Ok(_mapper.Map<CountryDto>(itemResult));
    }

    // DELETE api/Countries/5
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Delete(int id)
    {
        await _countryService.Delete(id);
        return NoContent();
    }

    [HttpPost]
    [AllowAnonymous]
    [Route("Migration")]
    public async Task<IActionResult> Migrate()
    {
        if (await _countryService.Any()) return BadRequest("Ya fue ejecutado");

        var list = new List<Domain.Entities.Country>()
        {
           new Domain.Entities.Country{Id=1, Name = "Afghanistan", Iso2="AF", Iso3="AFG", CountryCode="93",ContinentId=3,CurrencyId=2,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=2, Name = "Albania", Iso2="AL", Iso3="ALB", CountryCode="355",ContinentId=4,CurrencyId=3,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=3, Name = "Algeria", Iso2="DZ", Iso3="DZA", CountryCode="213",ContinentId=1,CurrencyId=38,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=4, Name = "American Samoa", Iso2="AS", Iso3="ASM", CountryCode="1 684",ContinentId=null,CurrencyId=138,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=5, Name = "Andorra", Iso2="AD", Iso3="AND", CountryCode="376",ContinentId=4,CurrencyId=42,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=6, Name = "Angola", Iso2="AO", Iso3="AGO", CountryCode="244",ContinentId=1,CurrencyId=5,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=7, Name = "Anguilla", Iso2="AI", Iso3="AIA", CountryCode="1 264",ContinentId=2,CurrencyId=146,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=8, Name = "Antigua and Barbuda", Iso2="AG", Iso3="ATG", CountryCode="1 268",ContinentId=2,CurrencyId=146,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=9, Name = "Argentina", Iso2="AR", Iso3="ARG", CountryCode="54",ContinentId=2,CurrencyId=6,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=10, Name = "Armenia", Iso2="AM", Iso3="ARM", CountryCode="374",ContinentId=3,CurrencyId=4,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=11, Name = "Aruba", Iso2="AW", Iso3="ABW", CountryCode="297",ContinentId=2,CurrencyId=8,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=12, Name = "Ascensión y Tristán de Acuña", Iso2="SH", Iso3="SHN", CountryCode="290",ContinentId=null,CurrencyId=120,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=13, Name = "Australia", Iso2="AU", Iso3="AUS", CountryCode="61",ContinentId=5,CurrencyId=7,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=14, Name = "Austria", Iso2="AT", Iso3="AUT", CountryCode="43",ContinentId=4,CurrencyId=42,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=15, Name = "Azerbaijan", Iso2="AZ", Iso3="AZE", CountryCode="994",ContinentId=3,CurrencyId=9,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=16, Name = "Bahamas", Iso2="BS", Iso3="BHS", CountryCode="1 242",ContinentId=2,CurrencyId=20,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=17, Name = "Bahrain", Iso2="BH", Iso3="BHR", CountryCode="973",ContinentId=3,CurrencyId=14,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=18, Name = "Bangladesh", Iso2="BD", Iso3="BGD", CountryCode="880",ContinentId=3,CurrencyId=12,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=19, Name = "Barbados", Iso2="BB", Iso3="BRB", CountryCode="1 246",ContinentId=2,CurrencyId=11,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=20, Name = "Belarus", Iso2="BY", Iso3="BLR", CountryCode="375",ContinentId=4,CurrencyId=23,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=21, Name = "Belgium", Iso2="BE", Iso3="BEL", CountryCode="32",ContinentId=4,CurrencyId=42,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=22, Name = "Belize", Iso2="BZ", Iso3="BLZ", CountryCode="501",ContinentId=2,CurrencyId=24,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=23, Name = "Benin", Iso2="BJ", Iso3="BEN", CountryCode="229",ContinentId=1,CurrencyId=145,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=24, Name = "Bermuda Islands", Iso2="BM", Iso3="BMU", CountryCode="1 441",ContinentId=null,CurrencyId=16,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=25, Name = "Bhutan", Iso2="BT", Iso3="BTN", CountryCode="975",ContinentId=3,CurrencyId=21,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=26, Name = "Bolivia", Iso2="BO", Iso3="BOL", CountryCode="591",ContinentId=2,CurrencyId=18,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=27, Name = "Bosnia and Herzegovina", Iso2="BA", Iso3="BIH", CountryCode="387",ContinentId=4,CurrencyId=10,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=28, Name = "Botswana", Iso2="BW", Iso3="BWA", CountryCode="267",ContinentId=1,CurrencyId=22,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=29, Name = "Brazil", Iso2="BR", Iso3="BRA", CountryCode="55",ContinentId=2,CurrencyId=19,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=30, Name = "British Indian Ocean Territory", Iso2="IO", Iso3="IOT", CountryCode="246",ContinentId=null,CurrencyId=45,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=31, Name = "Brunei", Iso2="BN", Iso3="BRN", CountryCode="673",ContinentId=3,CurrencyId=17,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=32, Name = "Bulgaria", Iso2="BG", Iso3="BGR", CountryCode="359",ContinentId=4,CurrencyId=13,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=33, Name = "Burkina Faso", Iso2="BF", Iso3="BFA", CountryCode="226",ContinentId=1,CurrencyId=145,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=34, Name = "Burundi", Iso2="BI", Iso3="BDI", CountryCode="257",ContinentId=1,CurrencyId=15,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=35, Name = "Cambodia", Iso2="KH", Iso3="KHM", CountryCode="855",ContinentId=3,CurrencyId=69,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=36, Name = "Cameroon", Iso2="CM", Iso3="CMR", CountryCode="237",ContinentId=1,CurrencyId=145,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=37, Name = "Canada", Iso2="CA", Iso3="CAN", CountryCode="1",ContinentId=2,CurrencyId=25,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=38, Name = "Cape Verde", Iso2="CV", Iso3="CPV", CountryCode="238",ContinentId=1,CurrencyId=33,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=39, Name = "Cayman Islands", Iso2="KY", Iso3="CYM", CountryCode="1 345",ContinentId=null,CurrencyId=73,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=40, Name = "Central African Republic", Iso2="CF", Iso3="CAF", CountryCode="236",ContinentId=1,CurrencyId=145,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=41, Name = "Chad", Iso2="TD", Iso3="TCD", CountryCode="235",ContinentId=1,CurrencyId=145,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=42, Name = "Chile", Iso2="CL", Iso3="CHL", CountryCode="56",ContinentId=2,CurrencyId=28,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=43, Name = "China", Iso2="CN", Iso3="CHN", CountryCode="86",ContinentId=3,CurrencyId=29,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=44, Name = "Christmas Island", Iso2="CX", Iso3="CXR", CountryCode="61",ContinentId=null,CurrencyId=7,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=45, Name = "Colombia", Iso2="CO", Iso3="COL", CountryCode="57",ContinentId=2,CurrencyId=30,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=46, Name = "Cook Islands", Iso2="CK", Iso3="COK", CountryCode="682",ContinentId=null,CurrencyId=100,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=47, Name = "Costa Rica", Iso2="CR", Iso3="CRI", CountryCode="506",ContinentId=2,CurrencyId=31,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=48, Name = "Croatia", Iso2="HR", Iso3="HRV", CountryCode="385",ContinentId=4,CurrencyId=55,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=49, Name = "Cuba", Iso2="CU", Iso3="CUB", CountryCode="53",ContinentId=2,CurrencyId=32,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=50, Name = "Curaçao", Iso2="CW", Iso3="CWU", CountryCode="5999",ContinentId=2,CurrencyId=8,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=51, Name = "Cyprus", Iso2="CY", Iso3="CYP", CountryCode="357",ContinentId=4,CurrencyId=42,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=52, Name = "Czech Republic", Iso2="CZ", Iso3="CZE", CountryCode="420",ContinentId=4,CurrencyId=34,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=53, Name = "Democratic Republic of the Congo", Iso2="CD", Iso3="COD", CountryCode="243",ContinentId=1,CurrencyId=26,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=54, Name = "Denmark", Iso2="DK", Iso3="DNK", CountryCode="45",ContinentId=4,CurrencyId=36,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=55, Name = "Djibouti", Iso2="DJ", Iso3="DJI", CountryCode="253",ContinentId=1,CurrencyId=35,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=56, Name = "Dominica", Iso2="DM", Iso3="DMA", CountryCode="1 767",ContinentId=2,CurrencyId=146,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=57, Name = "Dominican Republic", Iso2="DO", Iso3="DOM", CountryCode="1 809",ContinentId=2,CurrencyId=37,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=58, Name = "East Timor", Iso2="TL", Iso3="TLS", CountryCode="670",ContinentId=5,CurrencyId=138,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=59, Name = "Ecuador", Iso2="EC", Iso3="ECU", CountryCode="593",ContinentId=2,CurrencyId=138,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=60, Name = "Egypt", Iso2="EG", Iso3="EGY", CountryCode="20",ContinentId=1,CurrencyId=39,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=61, Name = "El Salvador", Iso2="SV", Iso3="SLV", CountryCode="503",ContinentId=2,CurrencyId=138,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=62, Name = "Equatorial Guinea", Iso2="GQ", Iso3="GNQ", CountryCode="240",ContinentId=1,CurrencyId=145,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=63, Name = "Eritrea", Iso2="ER", Iso3="ERI", CountryCode="291",ContinentId=1,CurrencyId=40,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=64, Name = "Estonia", Iso2="EE", Iso3="EST", CountryCode="372",ContinentId=4,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=65, Name = "Ethiopia", Iso2="ET", Iso3="ETH", CountryCode="251",ContinentId=1,CurrencyId=41,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=66, Name = "Falkland Islands (Malvinas)", Iso2="FK", Iso3="FLK", CountryCode="500",ContinentId=null,CurrencyId=44,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=67, Name = "Fiji", Iso2="FJ", Iso3="FJI", CountryCode="679",ContinentId=5,CurrencyId=43,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=68, Name = "Finland", Iso2="FI", Iso3="FIN", CountryCode="358",ContinentId=4,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=69, Name = "France", Iso2="FR", Iso3="FRA", CountryCode="33",ContinentId=4,CurrencyId=42,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=70, Name = "French Polynesia", Iso2="PF", Iso3="PYF", CountryCode="689",ContinentId=null,CurrencyId=147,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=71, Name = "Gabon", Iso2="GA", Iso3="GAB", CountryCode="241",ContinentId=1,CurrencyId=145,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=72, Name = "Gambia", Iso2="GM", Iso3="GMB", CountryCode="220",ContinentId=1,CurrencyId=49,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=73, Name = "Georgia", Iso2="GE", Iso3="GEO", CountryCode="995",ContinentId=3,CurrencyId=46,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=74, Name = "Germany", Iso2="DE", Iso3="DEU", CountryCode="49",ContinentId=4,CurrencyId=42,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=75, Name = "Ghana", Iso2="GH", Iso3="GHA", CountryCode="233",ContinentId=1,CurrencyId=47,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=76, Name = "Gibraltar", Iso2="GI", Iso3="GIB", CountryCode="350",ContinentId=null,CurrencyId=48,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=77, Name = "Greece", Iso2="GR", Iso3="GRC", CountryCode="30",ContinentId=4,CurrencyId=42,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=78, Name = "Grenada", Iso2="GD", Iso3="GRD", CountryCode="1 473",ContinentId=2,CurrencyId=146,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=79, Name = "Guam", Iso2="GU", Iso3="GUM", CountryCode="1 671",ContinentId=null,CurrencyId=138,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=80, Name = "Guatemala", Iso2="GT", Iso3="GTM", CountryCode="502",ContinentId=2,CurrencyId=51,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=81, Name = "Guinea", Iso2="GN", Iso3="GIN", CountryCode="224",ContinentId=1,CurrencyId=50,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=82, Name = "Guinea-Bissau", Iso2="GW", Iso3="GNB", CountryCode="245",ContinentId=1,CurrencyId=145,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=83, Name = "Guyana", Iso2="GY", Iso3="GUY", CountryCode="592",ContinentId=2,CurrencyId=52,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=84, Name = "Haiti", Iso2="HT", Iso3="HTI", CountryCode="509",ContinentId=2,CurrencyId=138,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=85, Name = "Honduras", Iso2="HN", Iso3="HND", CountryCode="504",ContinentId=2,CurrencyId=54,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=86, Name = "Hong Kong", Iso2="HK", Iso3="HKG", CountryCode="852",ContinentId=3,CurrencyId=53,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=87, Name = "Hungary", Iso2="HU", Iso3="HUN", CountryCode="36",ContinentId=4,CurrencyId=57,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=88, Name = "Iceland", Iso2="IS", Iso3="ISL", CountryCode="354",ContinentId=null,CurrencyId=63,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=89, Name = "India", Iso2="IN", Iso3="IND", CountryCode="91",ContinentId=3,CurrencyId=60,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=90, Name = "Indonesia", Iso2="ID", Iso3="IDN", CountryCode="62",ContinentId=3,CurrencyId=58,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=91, Name = "Iran", Iso2="IR", Iso3="IRN", CountryCode="98",ContinentId=3,CurrencyId=62,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=92, Name = "Iraq", Iso2="IQ", Iso3="IRQ", CountryCode="964",ContinentId=3,CurrencyId=61,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=93, Name = "Ireland", Iso2="IE", Iso3="IRL", CountryCode="353",ContinentId=4,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=94, Name = "Isle of Man", Iso2="IM", Iso3="IMN", CountryCode="44",ContinentId=null,CurrencyId=45,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=95, Name = "Israel", Iso2="IL", Iso3="ISR", CountryCode="972",ContinentId=3,CurrencyId=59,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=96, Name = "Italy", Iso2="IT", Iso3="ITA", CountryCode="39",ContinentId=4,CurrencyId=42,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=97, Name = "Ivory Coast", Iso2="CI", Iso3="CIV", CountryCode="225",ContinentId=1,CurrencyId=145,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=98, Name = "Jamaica", Iso2="JM", Iso3="JAM", CountryCode="1 876",ContinentId=2,CurrencyId=64,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=99, Name = "Japan", Iso2="JP", Iso3="JPN", CountryCode="81",ContinentId=3,CurrencyId=66,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=100, Name = "Jordan", Iso2="JO", Iso3="JOR", CountryCode="962",ContinentId=3,CurrencyId=65,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=101, Name = "Kazakhstan", Iso2="KZ", Iso3="KAZ", CountryCode="7",ContinentId=3,CurrencyId=74,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=102, Name = "Kenya", Iso2="KE", Iso3="KEN", CountryCode="254",ContinentId=1,CurrencyId=67,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=103, Name = "Kiribati", Iso2="KI", Iso3="KIR", CountryCode="686",ContinentId=5,CurrencyId=7,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=104, Name = "Kuwait", Iso2="KW", Iso3="KWT", CountryCode="965",ContinentId=3,CurrencyId=72,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=105, Name = "Kyrgyzstan", Iso2="KG", Iso3="KGZ", CountryCode="996",ContinentId=3,CurrencyId=68,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=106, Name = "Laos", Iso2="LA", Iso3="LAO", CountryCode="856",ContinentId=3,CurrencyId=75,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=107, Name = "Latvia", Iso2="LV", Iso3="LVA", CountryCode="371",ContinentId=4,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=108, Name = "Lebanon", Iso2="LB", Iso3="LBN", CountryCode="961",ContinentId=3,CurrencyId=76,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=109, Name = "Lesotho", Iso2="LS", Iso3="LSO", CountryCode="266",ContinentId=1,CurrencyId=79,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=110, Name = "Liberia", Iso2="LR", Iso3="LBR", CountryCode="231",ContinentId=1,CurrencyId=78,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=111, Name = "Libya", Iso2="LY", Iso3="LBY", CountryCode="218",ContinentId=1,CurrencyId=80,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=112, Name = "Liechtenstein", Iso2="LI", Iso3="LIE", CountryCode="423",ContinentId=4,CurrencyId=27,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=113, Name = "Lithuania", Iso2="LT", Iso3="LTU", CountryCode="370",ContinentId=4,CurrencyId=42,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=114, Name = "Luxembourg", Iso2="LU", Iso3="LUX", CountryCode="352",ContinentId=4,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=115, Name = "Macao", Iso2="MO", Iso3="MAC", CountryCode="853",ContinentId=3,CurrencyId=87,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=116, Name = "Macedonia", Iso2="MK", Iso3="MKD", CountryCode="389",ContinentId=4,CurrencyId=84,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=117, Name = "Madagascar", Iso2="MG", Iso3="MDG", CountryCode="261",ContinentId=1,CurrencyId=83,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=118, Name = "Malawi", Iso2="MW", Iso3="MWI", CountryCode="265",ContinentId=1,CurrencyId=91,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=119, Name = "Malaysia", Iso2="MY", Iso3="MYS", CountryCode="60",ContinentId=3,CurrencyId=93,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=120, Name = "Maldives", Iso2="MV", Iso3="MDV", CountryCode="960",ContinentId=null,CurrencyId=90,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=121, Name = "Mali", Iso2="ML", Iso3="MLI", CountryCode="223",ContinentId=1,CurrencyId=145,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=122, Name = "Malta", Iso2="MT", Iso3="MLT", CountryCode="356",ContinentId=4,CurrencyId=42,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=123, Name = "Marshall Islands", Iso2="MH", Iso3="MHL", CountryCode="692",ContinentId=5,CurrencyId=138,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=124, Name = "Martinique", Iso2="MQ", Iso3="MTQ", CountryCode="596",ContinentId=2,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=125, Name = "Mauritania", Iso2="MR", Iso3="MRT", CountryCode="222",ContinentId=1,CurrencyId=88,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=126, Name = "Mauritius", Iso2="MU", Iso3="MUS", CountryCode="230",ContinentId=1,CurrencyId=89,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=127, Name = "Mexico", Iso2="MX", Iso3="MEX", CountryCode="52",ContinentId=2,CurrencyId=92,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=128, Name = "Moldova", Iso2="MD", Iso3="MDA", CountryCode="373",ContinentId=4,CurrencyId=82,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=129, Name = "Monaco", Iso2="MC", Iso3="MCO", CountryCode="377",ContinentId=4,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=130, Name = "Mongolia", Iso2="MN", Iso3="MNG", CountryCode="976",ContinentId=3,CurrencyId=86,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=131, Name = "Montenegro", Iso2="ME", Iso3="MNE", CountryCode="382",ContinentId=4,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=132, Name = "Montserrat", Iso2="MS", Iso3="MSR", CountryCode="1 664",ContinentId=2,CurrencyId=146,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=133, Name = "Morocco", Iso2="MA", Iso3="MAR", CountryCode="212",ContinentId=1,CurrencyId=81,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=134, Name = "Mozambique", Iso2="MZ", Iso3="MOZ", CountryCode="258",ContinentId=1,CurrencyId=94,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=135, Name = "Myanmar", Iso2="MM", Iso3="MMR", CountryCode="95",ContinentId=3,CurrencyId=85,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=136, Name = "Namibia", Iso2="NA", Iso3="NAM", CountryCode="264",ContinentId=1,CurrencyId=95,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=137, Name = "Nauru", Iso2="NR", Iso3="NRU", CountryCode="674",ContinentId=5,CurrencyId=7,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=138, Name = "Nepal", Iso2="NP", Iso3="NPL", CountryCode="977",ContinentId=3,CurrencyId=99,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=139, Name = "Netherlands", Iso2="NL", Iso3="NLD", CountryCode="31",ContinentId=4,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=140, Name = "New Caledonia", Iso2="NC", Iso3="NCL", CountryCode="687",ContinentId=5,CurrencyId=147,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=141, Name = "New Zealand", Iso2="NZ", Iso3="NZL", CountryCode="64",ContinentId=5,CurrencyId=100,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=142, Name = "Nicaragua", Iso2="NI", Iso3="NIC", CountryCode="505",ContinentId=2,CurrencyId=97,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=143, Name = "Niger", Iso2="NE", Iso3="NER", CountryCode="227",ContinentId=1,CurrencyId=145,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=144, Name = "Nigeria", Iso2="NG", Iso3="NGA", CountryCode="234",ContinentId=1,CurrencyId=96,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=145, Name = "Niue", Iso2="NU", Iso3="NIU", CountryCode="683",ContinentId=5,CurrencyId=100,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=146, Name = "North Korea", Iso2="KP", Iso3="PRK", CountryCode="850",ContinentId=3,CurrencyId=70,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=147, Name = "Norway", Iso2="NO", Iso3="NOR", CountryCode="47",ContinentId=4,CurrencyId=98,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=148, Name = "Oman", Iso2="OM", Iso3="OMN", CountryCode="968",ContinentId=3,CurrencyId=101,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=149, Name = "Pakistan", Iso2="PK", Iso3="PAK", CountryCode="92",ContinentId=3,CurrencyId=106,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=150, Name = "Palau", Iso2="PW", Iso3="PLW", CountryCode="680",ContinentId=5,CurrencyId=138,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=151, Name = "Palestine", Iso2="PS", Iso3="PSE", CountryCode="970",ContinentId=3,CurrencyId=59,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=152, Name = "Panama", Iso2="PA", Iso3="PAN", CountryCode="507",ContinentId=2,CurrencyId=138,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=153, Name = "Papua New Guinea", Iso2="PG", Iso3="PNG", CountryCode="675",ContinentId=5,CurrencyId=104,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=154, Name = "Paraguay", Iso2="PY", Iso3="PRY", CountryCode="595",ContinentId=2,CurrencyId=108,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=155, Name = "Peru", Iso2="PE", Iso3="PER", CountryCode="51",ContinentId=2,CurrencyId=103,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=156, Name = "Philippines", Iso2="PH", Iso3="PHL", CountryCode="63",ContinentId=3,CurrencyId=105,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=157, Name = "Pitcairn Islands", Iso2="PN", Iso3="PCN", CountryCode="870",ContinentId=5,CurrencyId=100,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=158, Name = "Poland", Iso2="PL", Iso3="POL", CountryCode="48",ContinentId=4,CurrencyId=107,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=159, Name = "Portugal", Iso2="PT", Iso3="PRT", CountryCode="351",ContinentId=4,CurrencyId=42,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=160, Name = "Puerto Rico", Iso2="PR", Iso3="PRI", CountryCode="1",ContinentId=2,CurrencyId=138,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=161, Name = "Qatar", Iso2="QA", Iso3="QAT", CountryCode="974",ContinentId=3,CurrencyId=109,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=162, Name = "Republic of the Congo", Iso2="CG", Iso3="COG", CountryCode="242",ContinentId=1,CurrencyId=145,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=163, Name = "Romania", Iso2="RO", Iso3="ROU", CountryCode="40",ContinentId=4,CurrencyId=110,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=164, Name = "Russia", Iso2="RU", Iso3="RUS", CountryCode="7",ContinentId=4,CurrencyId=112,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=165, Name = "Rwanda", Iso2="RW", Iso3="RWA", CountryCode="250",ContinentId=1,CurrencyId=113,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=166, Name = "Saint Kitts and Nevis", Iso2="KN", Iso3="KNA", CountryCode="1 869",ContinentId=2,CurrencyId=146,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=167, Name = "Saint Lucia", Iso2="LC", Iso3="LCA", CountryCode="1 758",ContinentId=2,CurrencyId=146,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=168, Name = "Saint Vincent and the Grenadines", Iso2="VC", Iso3="VCT", CountryCode="1 784",ContinentId=2,CurrencyId=146,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=169, Name = "Samoa", Iso2="WS", Iso3="WSM", CountryCode="685",ContinentId=5,CurrencyId=144,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=170, Name = "San Marino", Iso2="SM", Iso3="SMR", CountryCode="378",ContinentId=4,CurrencyId=42,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=171, Name = "Sao Tome and Principe", Iso2="ST", Iso3="STP", CountryCode="239",ContinentId=1,CurrencyId=124,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=172, Name = "Saudi Arabia", Iso2="SA", Iso3="SAU", CountryCode="966",ContinentId=3,CurrencyId=114,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=173, Name = "Senegal", Iso2="SN", Iso3="SEN", CountryCode="221",ContinentId=1,CurrencyId=145,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=174, Name = "Serbia", Iso2="RS", Iso3="SRB", CountryCode="381",ContinentId=4,CurrencyId=111,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=175, Name = "Seychelles", Iso2="SC", Iso3="SYC", CountryCode="248",ContinentId=1,CurrencyId=116,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=176, Name = "Sierra Leone", Iso2="SL", Iso3="SLE", CountryCode="232",ContinentId=1,CurrencyId=121,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=177, Name = "Singapore", Iso2="SG", Iso3="SGP", CountryCode="65",ContinentId=3,CurrencyId=119,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=178, Name = "Slovakia", Iso2="SK", Iso3="SVK", CountryCode="421",ContinentId=4,CurrencyId=42,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=179, Name = "Slovenia", Iso2="SI", Iso3="SVN", CountryCode="386",ContinentId=4,CurrencyId=42,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=180, Name = "Solomon Islands", Iso2="SB", Iso3="SLB", CountryCode="677",ContinentId=5,CurrencyId=115,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=181, Name = "Somalia", Iso2="SO", Iso3="SOM", CountryCode="252",ContinentId=1,CurrencyId=122,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=182, Name = "South Africa", Iso2="ZA", Iso3="ZAF", CountryCode="27",ContinentId=1,CurrencyId=149,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=183, Name = "South Korea", Iso2="KR", Iso3="KOR", CountryCode="82",ContinentId=3,CurrencyId=71,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=184, Name = "Spain", Iso2="ES", Iso3="ESP", CountryCode="34",ContinentId=4,CurrencyId=42,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=185, Name = "Sri Lanka", Iso2="LK", Iso3="LKA", CountryCode="94",ContinentId=3,CurrencyId=77,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=186, Name = "Sudan", Iso2="SD", Iso3="SDN", CountryCode="249",ContinentId=1,CurrencyId=117,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=187, Name = "Suriname", Iso2="SR", Iso3="SUR", CountryCode="597",ContinentId=2,CurrencyId=123,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=188, Name = "Swaziland", Iso2="SZ", Iso3="SWZ", CountryCode="268",ContinentId=1,CurrencyId=126,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=189, Name = "Sweden", Iso2="SE", Iso3="SWE", CountryCode="46",ContinentId=4,CurrencyId=118,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=190, Name = "Switzerland", Iso2="CH", Iso3="CHE", CountryCode="41",ContinentId=4,CurrencyId=27,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=191, Name = "Syria", Iso2="SY", Iso3="SYR", CountryCode="963",ContinentId=3,CurrencyId=125,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=192, Name = "Taiwan", Iso2="TW", Iso3="TWN", CountryCode="886",ContinentId=3,CurrencyId=134,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=193, Name = "Tajikistan", Iso2="TJ", Iso3="TJK", CountryCode="992",ContinentId=3,CurrencyId=128,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=194, Name = "Tanzania", Iso2="TZ", Iso3="TZA", CountryCode="255",ContinentId=1,CurrencyId=135,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=195, Name = "Thailand", Iso2="TH", Iso3="THA", CountryCode="66",ContinentId=3,CurrencyId=127,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=196, Name = "Togo", Iso2="TG", Iso3="TGO", CountryCode="228",ContinentId=1,CurrencyId=145,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=197, Name = "Tonga", Iso2="TO", Iso3="TON", CountryCode="676",ContinentId=5,CurrencyId=131,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=198, Name = "Trinidad and Tobago", Iso2="TT", Iso3="TTO", CountryCode="1 868",ContinentId=2,CurrencyId=133,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=199, Name = "Tunisia", Iso2="TN", Iso3="TUN", CountryCode="216",ContinentId=1,CurrencyId=130,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=200, Name = "Turkey", Iso2="TR", Iso3="TUR", CountryCode="90",ContinentId=3,CurrencyId=132,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=201, Name = "Turkmenistan", Iso2="TM", Iso3="TKM", CountryCode="993",ContinentId=3,CurrencyId=129,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=202, Name = "Turks and Caicos Islands", Iso2="TC", Iso3="TCA", CountryCode="1 649",ContinentId=2,CurrencyId=138,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=203, Name = "Tuvalu", Iso2="TV", Iso3="TUV", CountryCode="688",ContinentId=5,CurrencyId=7,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=204, Name = "Uganda", Iso2="UG", Iso3="UGA", CountryCode="256",ContinentId=1,CurrencyId=137,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=205, Name = "Ukraine", Iso2="UA", Iso3="UKR", CountryCode="380",ContinentId=4,CurrencyId=136,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=206, Name = "United Arab Emirates", Iso2="AE", Iso3="ARE", CountryCode="971",ContinentId=3,CurrencyId=1,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=207, Name = "United Kingdom", Iso2="GB", Iso3="GBR", CountryCode="44",ContinentId=4,CurrencyId=45,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=208, Name = "United States of America", Iso2="US", Iso3="USA", CountryCode="1",ContinentId=2,CurrencyId=138,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=209, Name = "United States Virgin Islands", Iso2="VI", Iso3="VIR", CountryCode="1 340",ContinentId=2,CurrencyId=138,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=210, Name = "Uruguay", Iso2="UY", Iso3="URY", CountryCode="598",ContinentId=2,CurrencyId=139,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=211, Name = "Uzbekistan", Iso2="UZ", Iso3="UZB", CountryCode="998",ContinentId=3,CurrencyId=140,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=212, Name = "Vanuatu", Iso2="VU", Iso3="VUT", CountryCode="678",ContinentId=5,CurrencyId=143,IsActive = false,    CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=213, Name = "Vatican City State", Iso2="VA", Iso3="VAT", CountryCode="39",ContinentId=3,CurrencyId=42,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=214, Name = "Venezuela", Iso2="VE", Iso3="VEN", CountryCode="58",ContinentId=2,CurrencyId=141,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=215, Name = "Vietnam", Iso2="VN", Iso3="VNM", CountryCode="84",ContinentId=3,CurrencyId=142,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=216, Name = "Wallis and Futuna", Iso2="WF", Iso3="WLF", CountryCode="681",ContinentId=5,CurrencyId=147,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=217, Name = "Yemen", Iso2="YE", Iso3="YEM", CountryCode="967",ContinentId=3,CurrencyId=148,IsActive = false,  CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=218, Name = "Zambia", Iso2="ZM", Iso3="ZMB", CountryCode="260",ContinentId=1,CurrencyId=150,IsActive = false, CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
            new Domain.Entities.Country{Id=219, Name = "Zimbabwe", Iso2="ZW", Iso3="ZWE", CountryCode="263",ContinentId=1,CurrencyId=151,IsActive = false,   CreatedBy=0, CreatedAt =DateTimeOffset.Now, UpdatedBy=0, UpdatedAt = DateTimeOffset.Now},
        };
        foreach (var item in list)
        {
            item.CountryCode = $"+{item.CountryCode}";
            await _countryService.Create(item);
        }

        return Ok();
    }
}