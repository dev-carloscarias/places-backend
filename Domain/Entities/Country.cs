namespace Places.Domain.Entities;

public class Country : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public string Iso2 { get; set; } = string.Empty;

    public string Iso3 { get; set; } = string.Empty;

    public string CountryCode { get; set; } = string.Empty;

    public int? CurrencyId { get; set; } 

    public int? ContinentId { get; set; }

    public virtual Currency? Currency { get; set; } = null!;

    public virtual Continent? Continent { get; set; } = null!;

    public ICollection<Translate> Translates { get; set; } = [];
}