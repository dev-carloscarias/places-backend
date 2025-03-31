using Places.Domain.Dtos;

namespace Places.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class AmenitiesController : ControllerBase
{
    private readonly IAmenityService _amenityService;

    private readonly IMapper _mapper;

    public AmenitiesController(IAmenityService amenityService, IMapper mapper)
    {
        _amenityService = amenityService;
        _mapper = mapper;
    }

    // GET: api/Amenities
    [HttpGet]
    [AllowAnonymous]
    [Route("GetAll")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AmenityDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAll()
    {
        List<Amenity> itemsResult;

        itemsResult = (await _amenityService.GetAllActive() as List<Amenity>)!;
        return Ok(_mapper.Map<List<AmenityDto>>(itemsResult));
    }

    // GET: api/Amenities
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AmenityDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromQuery] QueryRequest queryRequest)
    {
        List<Amenity> itemsResult;

        if (queryRequest.SortOrder != null
           || queryRequest.CurrentFilter != null
           || queryRequest.SearchString != null
           || queryRequest.PageNumber != null
           || queryRequest.PageSize != null
           )
        {
            var queryResult = await _amenityService.GetByQueryRequestAsync(queryRequest);

            itemsResult = queryResult.Items;

            Response.Headers.Append("PaginationData", value: JsonConvert.SerializeObject(queryResult.PaginationData));

            return Ok(_mapper.Map<List<AmenityDto>>(itemsResult));
        }

        itemsResult = (await _amenityService.GetAll() as List<Amenity>)!;
        return Ok(_mapper.Map<List<AmenityDto>>(itemsResult));
    }

    // GET api/Amenities/5
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AmenityDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get(int id)
    {
        var itemResult = await _amenityService.GetById(id);
        return Ok(_mapper.Map<AmenityDto>(itemResult));
    }

    // POST api/Amenities
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AmenityDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Post([FromBody] AmenityDto amenityDto)
    {
        var itemResult = await _amenityService.Create(_mapper.Map<AmenityDto, Amenity>(amenityDto)!);
        var resourceUrl = $"{Request.Path}/{itemResult.Id}";
        return Created(resourceUrl, _mapper.Map<AmenityDto>(itemResult));
    }

    // PUT api/Amenities/5
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AmenityDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Put([FromBody] AmenityDto amenityDto)
    {
        var itemResult = await _amenityService.Edit(_mapper.Map<Amenity>(amenityDto)!);
        return Ok(_mapper.Map<AmenityDto>(itemResult));
    }

    // DELETE api/Amenities/5
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Delete(int id)
    {
        await _amenityService.Delete(id);
        return NoContent();
    }
}