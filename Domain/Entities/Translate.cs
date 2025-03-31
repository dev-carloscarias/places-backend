namespace Places.Domain.Entities;

public class Translate : EntityBase
{
    public string LanguageCode { get; set; } = string.Empty;

    public int? CurrencyId { get; set; }

    public int? CountryId { get; set; }

    public int? LanguageId { get; set; }

    public int? CommentId { get; set; }

    public int? MessageId { get; set; }

    public int? LabelId { get; set; }

    public int? SiteId { get; set; }

    public int? CategoryId { get; set; }

    public string Translation { get; set; } = string.Empty;

    public string FieldName { get; set; } = string.Empty;

    public virtual Currency? Currency { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Language? Language { get; set; }

    public virtual Label? Label { get; set; }

    public virtual Site? Site { get; set; }

    public virtual Category? Category { get; set; }
}