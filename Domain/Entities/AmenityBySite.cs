namespace Places.Domain.Entities;

public class AmenityBySite : EntityBase
{
    public int SiteId { get; set; }

    public int AmenityId { get; set; }

    public string Description { get; set; } = string.Empty;

    public virtual Site Site { get; set; } = null!;

    public virtual Amenity Amenity { get; set; } = null!;
}