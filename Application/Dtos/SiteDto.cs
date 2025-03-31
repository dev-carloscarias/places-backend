namespace Places.Application.Dtos;

public class SiteDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public int CurrencyId { get; set; }

    public int CountryId { get; set; }
    public int RegionId { get; set; }
    public bool NewRegion { get; set; } = false;
    public string NewRegionName { get; set; } = string.Empty;

    public bool IsSiteApproved { get; set; } = false;
    public bool IsActive { get; set; } = false;
    public bool? IsSiteRejected { get; set; }
    public string RejectReason { get; set; } = null!;

    public int CategoryId { get; set; }
    public decimal AdultPrice { get; set; }
    public decimal ChildPrice { get; set; }
    public decimal TotalPrice { get; set; }

    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public bool IsPublic { get; set; } = true;
    public int Capacity { get; set; }

    public List<string> SitePolicies { get; set; } = new List<string>();
    public DateTimeOffset CreatedAt { get; set; }
    public List<AmenityBySiteDto> Amenities { get; set; } = new List<AmenityBySiteDto>();
    public List<AmenityDto> AmenitiesDto { get; set; } = new List<AmenityDto>();
    public List<DataFileDto> Photos { get; set; }
    public List<AvailabilityDto> Availabilities { get; set; }
    public List<DateTime> SelectedDates { get; set; } = new();
    public string SelectedDatesString => string.Join(";", SelectedDates.Select(date => date.ToString("yyyy-MM-dd")));
    public SpecialPackageDto? SpecialPackage { get; set; }
    public List<AdditionalCostDto> AdditionalCosts { get; set; } = new List<AdditionalCostDto>();
    public List<SelectedTransportOptionDto> SelectedTransportOptions { get; set; } = new();
}