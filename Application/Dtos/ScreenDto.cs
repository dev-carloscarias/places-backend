namespace Places.Application.Dtos;

public class ScreenDto
{
    public int Id { get; set; }

    public string ScreenCode { get; set; } = string.Empty;

    public List<LabelDto> Labels { get; set; } = [];
}