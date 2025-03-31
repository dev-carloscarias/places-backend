namespace Places.Domain.Entities;

public class Category : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public int LanguageId { get; set; }

    public ICollection<Translate> Translates { get; set; } = [];
    public ICollection<DataFile> DataFiles { get; set; } = [];
}