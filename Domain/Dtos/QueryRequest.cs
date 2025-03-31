namespace Places.Domain.Dtos;

[ExcludeFromCodeCoverage]
public class QueryRequest
{
    public int? PageNumber { get; set; } = null;

    public int? PageSize { get; set; } = null;

    public string? SortOrder { get; set; } = null;

    public string? SearchString { get; set; } = null;

    public string? CurrentFilter { get; set; } = null;
}