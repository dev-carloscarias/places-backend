namespace Places.Domain.Entities;

public class Label : EntityBase
{
    public string LabelCode { get; set; } = string.Empty;

    public string LabelValue { get; set; } = string.Empty;

    public int ScreenId { get; set; }

    public virtual Screen Screen { get; set; }
}