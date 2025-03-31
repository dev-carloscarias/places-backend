namespace Places.Domain.Entities;

public class DataFile : EntityBase
{
    public string Path { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Section { get; set; } = string.Empty;

    public int FileOrder { get; set; }

    public int? SiteId { get; set; }

    public int? AmenityId { get; set; }

    public int? UserId { get; set; }
    public int? OwnerId { get; set; }

    public DataFileType DataFileType { get; set; }

    public DataTypeExtension DataTypeExtension { get; set; }

    public virtual Site? Site { get; set; }
    public virtual Category? Category { get; set; }

    public virtual Amenity? Amenity { get; set; }

    public virtual User? User { get; set; }
}