using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Places.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransportOptionController : ControllerBase
{
    private readonly ITransportOptionService _transportOptionService;

    public TransportOptionController(ITransportOptionService transportOptionService)
    {
        _transportOptionService = transportOptionService;
    }

    // Obtener todas las opciones de transporte
    [HttpGet]
    public async Task<IActionResult> GetAllTransportOptions()
    {
        var result = await _transportOptionService.GetAllTransportOptionsAsync();
        return Ok(result);
    }

    // Obtener una opción específica por ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTransportOptionById(int id)
    {
        var result = await _transportOptionService.GetTransportOptionByIdAsync(id);
        if (result == null)
        {
            return NotFound("TransportOption not found.");
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddTransportOption([FromBody] TransportOptionDto transportOptionDto)
    {
        var result = await _transportOptionService.AddTransportOptionAsync(transportOptionDto);
        if (result == null)
        {
            return BadRequest("Failed to add TransportOption.");
        }
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTransportOption(int id, [FromBody] TransportOptionDto transportOptionDto)
    {
        var result = await _transportOptionService.UpdateTransportOptionAsync(id, transportOptionDto);
        if (result == null)
        {
            return NotFound("TransportOption not found.");
        }
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTransportOption(int id)
    {
        var success = await _transportOptionService.DeleteTransportOptionAsync(id);
        if (!success)
        {
            return NotFound("TransportOption not found.");
        }
        return NoContent();
    }
}
