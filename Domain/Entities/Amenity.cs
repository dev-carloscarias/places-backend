namespace Places.Domain.Entities;

public class Amenity : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<DataFile> Files { get; set; }

    public virtual ICollection<AmenityBySite> AmenityBySites { get; set; } = [];
}