namespace Places.Application.Dtos;

public class CurrencyDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string CurrencyCode { get; set; } = string.Empty;

    public string Symbol { get; set; } = string.Empty;

    public decimal Rate { get; set; }
}