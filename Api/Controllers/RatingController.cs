using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Places.Domain.Entities;

namespace Places.Api.Controllers;
[ApiController]
[Route("api/v1/[controller]")]
public class RatingsController : ControllerBase
{
    private readonly IRatingService _ratingService;
    private readonly IMapper _mapper;

    public RatingsController(IRatingService ratingService, IMapper mapper)
    {
        _ratingService = ratingService;
        _mapper = mapper;
    }

    /// <summary>
    /// Obtener todas las calificaciones de un sitio
    /// </summary>
    [HttpGet("site/{siteId}")]
    public async Task<IActionResult> GetRatingsForSite(int siteId)
    {
        var ratings = await _ratingService.GetRatingsBySiteIdAsync(siteId);
        var ratingsDto = _mapper.Map<IEnumerable<RatingDto>>(ratings);
        return Ok(ratingsDto);
    }

    /// <summary>
    /// Crear o actualizar rating de un usuario para un sitio
    /// </summary>
    [HttpPost("site/{siteId}")]
    public async Task<IActionResult> CreateOrUpdateRating(int siteId, [FromBody] CreateOrUpdateRatingDto dto)
    {
        // userId vendría del token o del body, según tu implementación
        var rating = await _ratingService.CreateOrUpdateRatingAsync(siteId, dto.UserId, dto.RatingValue);
        var ratingDto = _mapper.Map<RatingDto>(rating);
        return Ok(ratingDto);
    }

    /// <summary>
    /// Obtener el rating que un usuario dio a un sitio
    /// </summary>
    [HttpGet("site/{siteId}/user/{userId}")]
    public async Task<IActionResult> GetUserRating(int siteId, int userId)
    {
        var rating = await _ratingService.GetUserRatingForSiteAsync(siteId, userId);
        if (rating == null) return NotFound();
        return Ok(rating);
    }

    /// <summary>
    /// Eliminar un rating
    /// </summary>
    [HttpDelete("{ratingId}")]
    public async Task<IActionResult> DeleteRating(int ratingId, int userId)
    {
        await _ratingService.DeleteRatingAsync(ratingId, userId);
        return NoContent();
    }
}

public class CreateOrUpdateRatingDto
{
    public int UserId { get; set; }
    public int RatingValue { get; set; }
}
