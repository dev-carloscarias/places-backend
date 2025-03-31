namespace Places.Application.Dtos;

public class DataFileDto
{
    public int Id { get; set; }

    public string Path { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Section { get; set; } = string.Empty;

    public int FileOrder { get; set; }

    public DataFileType DataFileType { get; set; }

    public DataTypeExtension DataTypeExtension { get; set; }
}