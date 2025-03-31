namespace Places.Domain.Entities;

public class Site : EntityBase
{
    public int UserId { get; set; }
    public string Description { get; set; } = string.Empty;

    public int CurrencyId { get; set; }

    public int CountryId { get; set; }
    public int RegionId { get; set; }
    public bool NewRegion { get; set; }
    public string NewRegionName { get; set; } = string.Empty;
    public bool IsSiteApproved { get; set; } = false;
    public bool? IsSiteRejected { get; set; }
    public decimal AdultPrice { get; set; }
    public decimal ChildPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal TransportationPrice { get; set; }
    public string Title { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public bool IsPublic { get; set; } = true;
    public int Capacity { get; set; }
    public string RejectReason { get; set; } = null!;
    public int CategoryId { get; set; }
    public bool IsPendingToApprove { get; set; } = true;

    public string SitePolicies { get; set; } = string.Empty;

    public virtual SpecialPackage SpecialPackage { get; set; } = null!;

    public ICollection<AdditionalCost> AdditionalCosts { get; set; } = new List<AdditionalCost>();

    public virtual Category Category { get; set; }

    public virtual User User { get; set; } = null!;

    public ICollection<Translate> Translates { get; set; } = [];

    public ICollection<AmenityBySite> AmenityBySites { get; set; } = [];

    public ICollection<DataFile> DataFiles { get; set; } = [];
    public ICollection<Comment> Comments { get; set; } = [];
    public ICollection<Incident> Incidents { get; set; } = new List<Incident>();

    public virtual ICollection<Rating> Ratings { get; set; } = [];

    public string SelectedDates { get; set; } = string.Empty;  

    public ICollection<Availability> Availabilities { get; set; } = [];
    public ICollection<SelectedTransportOption> SelectedTransportOptions { get; set; } = new List<SelectedTransportOption>();
}