namespace Places.Domain.Entities;

public class Language : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public string LanguageCode { get; set; } = string.Empty;

    public ICollection<Translate> Translates { get; set; } = [];
}