using Places.Application.Dtos;
using Places.Application.Dtos.Site;
using Places.Domain.Common;
using Places.Domain.Dtos;
using System.Collections.Generic;

namespace Places.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class SitesController : ControllerBase
{
    private readonly ISiteService _siteService;
    private readonly ITemporaryImageService _temporaryImageService;
    private readonly IRegionService _regionService;
    private readonly ICountryService _countryService;
  
    private readonly IMapper _mapper;

    public SitesController(ISiteService siteService, IMapper mapper, ICountryService countryService, ITemporaryImageService temporaryImageService, IRegionService regionService)
    {
        _siteService = siteService;
        _countryService = countryService;
        _mapper = mapper;
        _temporaryImageService = temporaryImageService;
        _regionService = regionService;
    }

    // GET: api/Amenities
    [HttpGet]
    [AllowAnonymous]
    [Route("GetAll")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAll()
    {
        List<Site> itemsResult;

        itemsResult = (await _siteService.GetAll() as List<Site>)!;
        return Ok(_mapper.Map<List<SiteDto>>(itemsResult));
    }

    // GET: api/Amenities
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromQuery] QueryRequest queryRequest)
    {
        List<Site> itemsResult;

        if (queryRequest.SortOrder != null
           || queryRequest.CurrentFilter != null
           || queryRequest.SearchString != null
           || queryRequest.PageNumber != null
           || queryRequest.PageSize != null
           )
        {
            var queryResult = await _siteService.GetByQueryRequestAsync(queryRequest);

            itemsResult = queryResult.Items;

            Response.Headers.Append("PaginationData", value: JsonConvert.SerializeObject(queryResult.PaginationData));

            return Ok(_mapper.Map<List<SiteDto>>(itemsResult));
        }

        itemsResult = (await _siteService.GetAll() as List<Site>)!;
        return Ok(_mapper.Map<List<SiteDto>>(itemsResult));
    }

    // GET api/Amenities/5
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SiteDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get(int id, string language)
    {
        var itemResult = await _siteService.GetByIdandLanguage(id, language);
        try
        {
            var item = _mapper.Map<SiteDto>(itemResult);
            item.AmenitiesDto = new List<AmenityDto>();
            itemResult.AmenityBySites.ToList().ForEach(d =>
            {
                var amenityDto = _mapper.Map<AmenityDto>(d.Amenity);
                amenityDto.Description = d.Description;
                amenityDto.Id = d.AmenityId;
                item.AmenitiesDto.Add(amenityDto);
            });
            return Ok(item);
        }
        catch (Exception ex )
        {
            return BadRequest(ex.Message);
        }
    }

    // POST api/Sites
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SiteDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Post()
    {
        var formCollection = await Request.ReadFormAsync();
        var siteDataJson = formCollection["siteData"];
        var sessionId = Int32.Parse(formCollection["sessionId"].ToString());
        var siteDto = JsonConvert.DeserializeObject<SiteDto>(siteDataJson);
        if (siteDto.NewRegion)
        {
            if (string.IsNullOrEmpty(siteDto.NewRegionName))
            {
                return BadRequest(new { Message = "Region name is required when creating a new region." });
            }

            var newRegion = new Region
            {
                Name = siteDto.NewRegionName,
                CountryId = siteDto.CountryId
            };
            await _regionService.Create(newRegion);
            siteDto.RegionId = newRegion.Id;
        }

        var site = _mapper.Map<SiteDto, Site>(siteDto)!;
        site = await _temporaryImageService.LinkImagesToSiteAsync(site.UserId, sessionId, site);

        var itemResult = await _siteService.Create(site);

        var resourceUrl = $"{Request.Path}/{itemResult.Id}";
        try
        {
            var item = _mapper.Map<SiteDto>(itemResult);
            var country = await _countryService.GetById(item.CountryId);
            if (!country.IsActive)
            {
                country.IsActive = true;
                await _countryService.Edit(country);
            }

            return Created(resourceUrl, item);
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
        return BadRequest(new { Message = "Invalid or missing userId" });
    }


    [HttpPost("UploadTemporaryImage")]
    public async Task<IActionResult> UploadTemporaryImage([FromForm] IFormCollection formCollection)
    {
        if (!formCollection.TryGetValue("userId", out var userIdValue) || !int.TryParse(userIdValue, out var userId))
        {
            return BadRequest(new { Message = "Invalid or missing userId" });
        }
        if (!formCollection.TryGetValue("sessionId", out var sessionIdValue) || !int.TryParse(sessionIdValue, out var sessionId))
        {
            return BadRequest(new { Message = "Invalid or missing userId" });
        }
        var uploadedImages = await _temporaryImageService.AddTemporaryImages(userId, sessionId, formCollection);
        var response = uploadedImages.Select(img => new
        {
            id = img.Id,
            path = img.Path,
            description = img.Description,
            section = img.Section,
            fileOrder = img.FileOrder,
            dataFileType = img.DataFileType.ToString(),
            dataTypeExtension = img.DataTypeExtension.ToString()
        });

        return Ok(new { Message = "Images uploaded temporarily", Images = response });
    }

    [HttpDelete("DeleteTemporaryImage/{id}")]
    public async Task<IActionResult> DeleteTemporaryImage(int id)
    {
        var image = await _temporaryImageService.GetImageByIdAsync(id);
        if (image == null)
        {
            return NotFound(new { Message = "Imagen no encontrada." });
        }

        await _temporaryImageService.DeletePermanentlyAsync(id);
        return Ok(new { Message = "Imagen eliminada exitosamente." });
    }

    [HttpGet("TemporaryImage/{id}/{sessionId}")]
    public async Task<IActionResult> GetTempImages(int id, int sessionId)
    {
        var image = await _temporaryImageService.GetImagesByUserIdandSessionAsync(id, sessionId);
        if (image == null)
        {
            return NotFound(new { Message = "Imagen no encontrada." });
        }

        return Ok(new { Message = "Images uploaded temporarily", Images = image });
    }

    [HttpPut("UpdateFileOrder")]
    public async Task<IActionResult> UpdateFileOrder([FromBody] UpdateFileOrderRequest request)
    {
        if (request == null || request.Id <= 0)
        {
            return BadRequest(new { Message = "Invalid request." });
        }

        var image = await _temporaryImageService.GetImageByIdAsync(request.Id);
        if (image == null)
        {
            return NotFound(new { Message = "Image not found." });
        }

        image.FileOrder = request.NewFileOrder;
        await _temporaryImageService.UpdateAsync(image);

        return Ok(new { Message = "File order updated successfully." });
    }

    // PUT api/Amenities/5
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SiteDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Put([FromBody] SiteDto siteDto)
    {
        var itemResult = await _siteService.Edit(_mapper.Map<Site>(siteDto)!);
        return Ok(_mapper.Map<SiteDto>(itemResult));
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
        await _siteService.Delete(id);
        return NoContent();
    }

    [HttpPost("SiteRegistrationApprobation")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SiteApprobationDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> OwnerApproved([FromBody] SiteApprobationDto siteApprobationDto)
    {
        await _siteService.SiteApprobation(siteApprobationDto);
        return Ok();
    }

    [HttpGet]
    [AllowAnonymous]
    [Route("GetAllPendingToApprove")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllPendingToApprove()
    {
        List<Site> itemsResult;

        itemsResult = (await _siteService.GetAllPendingToApprove() as List<Site>)!;
        return Ok(_mapper.Map<List<SiteDto>>(itemsResult));
    }

    [HttpGet]
    [AllowAnonymous]
    [Route("GetSitesbyOwner")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetSitesbyOwner(int userId)
    {
        List<Site> itemsResult;

        itemsResult = (await _siteService.GetSitesByOwner(userId) as List<Site>)!;
        return Ok(_mapper.Map<List<SiteDto>>(itemsResult));
    }


    [HttpGet]
    [AllowAnonymous]
    [Route("GetAllByCountry")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllByCountry(int countryId)
    {
        List<Site> itemsResult;

        itemsResult = (await _siteService.GetAllByCountry(countryId) as List<Site>)!;
        return Ok(_mapper.Map<List<SiteDto>>(itemsResult));
    }

    [HttpGet]
    [AllowAnonymous]
    [Route("GetAllByFilter")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllByFilter(string language, int countryId, int stateId, int categoryId, string? nombre = null, int pageNumber = 1, int pageSize = 10)
    {
        List<Site> itemsResult;

        itemsResult = (await _siteService.GetAllbyFilter(language,countryId, categoryId, stateId, nombre ?? "", pageNumber, pageSize) as List<Site>)!;
        List <SiteDto> sitesReturn = _mapper.Map<List<SiteDto>>(itemsResult);
        return Ok(sitesReturn);
    }

    [HttpGet]
    [AllowAnonymous]
    [Route("GetAllBySearch")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllBySearch(string language, string? nombre = null)
    {
        List<Site> itemsResult;

        itemsResult = (await _siteService.GetAllBySearch(language, nombre ?? "") as List<Site>)!;
        List<SiteDto> sitesReturn = _mapper.Map<List<SiteDto>>(itemsResult);
        return Ok(sitesReturn);
    }

    [HttpGet]
    [AllowAnonymous]
    [Route("GetAllbyManage")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<SiteDto>))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetAllbyManage(int countryId, int categoryId, string? nombre = null)
    {
        List<Site> itemsResult;

        itemsResult = (await _siteService.GetAllbyManage() as List<Site>)!;
        return Ok(_mapper.Map<List<SiteDto>>(itemsResult));
    }

    [HttpPut("ToggleActive/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> ToggleActive(int id)
    {
        var site = await _siteService.ToggleActive(id);
        return Ok(_mapper.Map<SiteDto>(site));
    }

    [HttpDelete("RemoveSite/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> DeleteSite(int id)
    {
        try
        {
            await _siteService.DeleteSite(id);
            return Ok();
        }
        catch (KeyNotFoundException)
        {
            return NotFound(new { Message = $"Site with id {id} not found." });
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new { Message = ex.Message });
        }
    }

    [HttpPut("{siteId}/Amenities")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SiteDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateAmenities(int siteId, [FromBody] List<AmenityDto> amenitiesDto)
    {
        try
        {
            var updatedSite = await _siteService.UpdateAmenities(siteId, amenitiesDto);
            return Ok(new { Message = "Ok" });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }

    [HttpPut("{siteId}/Features")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SiteDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateFeatures(int siteId, [FromBody] FeaturesDto featuresDto)
    {
        try
        {
            if (featuresDto.newRegion)
            {
                if (string.IsNullOrEmpty(featuresDto.CustomRegionName))
                {
                    throw new InvalidOperationException("Region name is required when creating a new region.");
                }

                var newRegion = new Region
                {
                    Name = featuresDto.CustomRegionName,
                    CountryId = featuresDto.CountryId
                };
                await _regionService.Create(newRegion);
                featuresDto.RegionId = newRegion.Id;
            }
            var updatedSite = await _siteService.UpdateFeatures(siteId, featuresDto);
            return Ok(new { Message = "Ok" });

        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }

    [HttpPut("{siteId}/Prices")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PricesDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdatePrices(int siteId, [FromBody] PricesDto pricesDto)
    {
        try
        {
            var updatedSite = await _siteService.UpdatePrices(siteId, pricesDto);
            return Ok(new { Message = "Ok" });

        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }


    [HttpPut("{siteId}/Schedule")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SiteDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateSchedule(int siteId, [FromBody] ScheduleDto scheduleDto)
    {
        try
        {
            var updatedSite = await _siteService.UpdateSchedule(siteId, scheduleDto);
            return Ok(new { Message = "Ok" });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }


    [HttpPut("{siteId}/Location")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SiteDto))]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateLocation(int siteId, [FromBody] LocationDto locationDto)
    {
        try
        {
            var updatedSite = await _siteService.UpdateLocation(siteId, locationDto);
            return Ok(new { Message = "Ok" });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }

    [HttpPut("{siteId}/Images/{sessionId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateImages(int siteId, int sessionId, [FromBody] UpdateImagesDto dto)
    {
        try
        {
            var site = await _siteService.GetByIdTracking(siteId);
            if (site == null) return NotFound(new { Message = "Site not found" });

            // Eliminar imágenes
            foreach (var removedImage in dto.RemovedImages)
            {
                var image = site.DataFiles.FirstOrDefault(df => df.Id == removedImage.Id);
                if (image != null)
                {
                    site.DataFiles.Remove(image);
                }
            }

            // Actualizar el orden de las imágenes
            foreach (var updatedImage in dto.UpdatedImages)
            {
                var image = site.DataFiles.FirstOrDefault(df => df.Id == updatedImage.Id);
                if (image != null)
                {
                    image.FileOrder = updatedImage.FileOrder;
                    image.Description = updatedImage.Description;
                }
            }

            site = await _temporaryImageService.LinkImagesToSiteAsync(site.UserId, sessionId, site);
            await _siteService.UpdateSite(site);
            return Ok(new { Message = "Imágenes actualizadas correctamente" });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
    }

    [HttpGet("{siteId}/incidents")]
    public async Task<IActionResult> GetIncidentsBySiteId(int siteId)
    {
        var incidents = await _siteService.GetIncidentsBySiteIdAsync(siteId);
        return Ok(incidents);
    }

    [HttpPost("{siteId}/incidents")]
    public async Task<IActionResult> AddIncident(int siteId, [FromBody] IncidentCreateDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Description))
            return BadRequest("La descripción del incidente no puede estar vacía.");

        var createdIncident = await _siteService.AddIncidentAsync(dto);
        return CreatedAtAction(nameof(GetIncidentsBySiteId), new { siteId }, createdIncident);
    }

    [HttpDelete("incidents/{incidentId}")]
    public async Task<IActionResult> DeleteIncident(int incidentId)
    {
        var result = await _siteService.DeleteIncidentAsync(incidentId);
        if (!result)
            return NotFound("Incidente no encontrado.");

        return NoContent();
    }

}