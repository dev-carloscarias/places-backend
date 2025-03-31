namespace Places.Application.Dtos;

public class AmenityDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public List<DataFileDto> Files { get; set; } = []!;
}