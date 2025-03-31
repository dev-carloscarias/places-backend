namespace Places.Application.Dtos;

public class AmenityBySiteDto
{
    public int Id { get; set; }
    public int AmenityId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int SiteId { get; set; }
}
