using Places.Domain.Dtos;

namespace Places.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class AmenitiesBySiteController : ControllerBase
{
    private readonly IAmenityBySiteService _amenityBySiteService;

    private readonly IAmenityService _amenityService;

    private readonly IMapper _mapper;

    public AmenitiesBySiteController(IAmenityBySiteService amenityBySiteService, IMapper mapper, IAmenityService amenityService)
    {
        _amenityBySiteService = amenityBySiteService;
        _mapper = mapper;
        _amenityService = amenityService;
    }

    // GET: api/Amenities
    [HttpGet]
    [AllowAnonymous]
    [Route("GetAllBySite/{siteId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AmenityBySiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAll([FromRoute] int siteId)
    {
        List<AmenityBySite> itemsResult;

        itemsResult = (await _amenityBySiteService.GetAll() as List<AmenityBySite>)!;

        var result = _mapper.Map<List<AmenityBySiteDto>>(itemsResult);
        foreach (var item in result)
            item.Name = (await _amenityService.GetById(item.AmenityId)).Name;

        return Ok(result);
    }

    // GET: api/Amenities
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AmenityBySiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromQuery] QueryRequest queryRequest)
    {
        List<AmenityBySite> itemsResult;

        if (queryRequest.SortOrder != null
           || queryRequest.CurrentFilter != null
           || queryRequest.SearchString != null
           || queryRequest.PageNumber != null
           || queryRequest.PageSize != null
           )
        {
            var queryResult = await _amenityBySiteService.GetByQueryRequestAsync(queryRequest);

            itemsResult = queryResult.Items;

            Response.Headers.Append("PaginationData", value: JsonConvert.SerializeObject(queryResult.PaginationData));

            return Ok(_mapper.Map<List<AmenityBySiteDto>>(itemsResult));
        }

        itemsResult = (await _amenityBySiteService.GetAll() as List<AmenityBySite>)!;
        return Ok(_mapper.Map<List<AmenityBySiteDto>>(itemsResult));
    }

    // POST api/Amenities
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AmenityBySiteDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Post([FromBody] AmenityBySiteDto amenityDto)
    {
        var itemResult = await _amenityBySiteService.Create(_mapper.Map<AmenityBySiteDto, AmenityBySite>(amenityDto)!);
        var resourceUrl = $"{Request.Path}/{itemResult.Id}";
        return Created(resourceUrl, _mapper.Map<AmenityBySiteDto>(itemResult));
    }

    // PUT api/Amenities/5
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AmenityBySiteDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Put([FromBody] AmenityBySiteDto amenityDto)
    {
        var itemResult = await _amenityBySiteService.Edit(_mapper.Map<AmenityBySite>(amenityDto)!);
        return Ok(_mapper.Map<AmenityBySiteDto>(itemResult));
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
        await _amenityBySiteService.Delete(id);
        return NoContent();
    }
}