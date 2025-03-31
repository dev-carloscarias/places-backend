using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Places.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegionsController : ControllerBase
{
    private readonly IRegionService _regionService;

    public RegionsController(IRegionService regionService)
    {
        _regionService = regionService;
    }

    // Obtener todas las regiones
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var regions = await _regionService.GetAll();
        return Ok(regions);
    }

    // Obtener una región por ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var region = await _regionService.GetById(id);
        if (region == null)
        {
            return NotFound(new { Message = "Region not found" });
        }
        return Ok(region);
    }

    // Obtener regiones por CountryId
    [HttpGet("ByCountry/{countryId}")]
    public async Task<IActionResult> GetByCountryId(int countryId)
    {
        var regions = await _regionService.GetByCountryId(countryId);
        if (!regions.Any())
        {
            return NotFound(new { Message = "No regions found for the specified country" });
        }
        return Ok(regions);
    }

    // Crear una nueva región
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] RegionDto regionDto)
    {
        if (string.IsNullOrEmpty(regionDto.Name))
        {
            return BadRequest(new { Message = "Region name is required" });
        }

        var region = new Region
        {
            Name = regionDto.Name,
            CountryId = regionDto.CountryId
        };

        var createdRegion = await _regionService.Create(region);
        return CreatedAtAction(nameof(GetById), new { id = createdRegion.Id }, createdRegion);
    }

    // Actualizar una región existente
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] RegionDto regionDto)
    {
        var existingRegion = await _regionService.GetById(id);
        if (existingRegion == null)
        {
            return NotFound(new { Message = "Region not found" });
        }

        existingRegion.Name = regionDto.Name;
        existingRegion.CountryId = regionDto.CountryId;

        var updatedRegion = await _regionService.Update(existingRegion);
        return Ok(updatedRegion);
    }

    // Eliminar una región
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var region = await _regionService.GetById(id);
        if (region == null)
        {
            return NotFound(new { Message = "Region not found" });
        }

        await _regionService.Delete(id);
        return NoContent();
    }
}
