namespace Places.Domain.Entities;

public class Screen : EntityBase
{
    public string ScreenCode { get; set; } = string.Empty;

    public ICollection<Label> Labels { get; set; } = [];
}