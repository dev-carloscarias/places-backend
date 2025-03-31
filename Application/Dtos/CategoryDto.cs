namespace Places.Application.Dtos;

public class CategoryDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public List<DataFileDto> DataFiles { get; set; }

}