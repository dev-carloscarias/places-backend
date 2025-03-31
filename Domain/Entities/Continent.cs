namespace Places.Domain.Entities;

public class Continent : EntityBase
{
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Country> Countries { get; set; } = [];
}