namespace Places.Domain.Entities;

public class Currency : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public string CurrencyCode { get; set; } = string.Empty;

    public string Symbol { get; set; } = string.Empty;

    public decimal Rate { get; set; }

    public virtual ICollection<Country> Countries { get; set; } = [];

    public ICollection<Translate> Translates { get; set; } = [];
}