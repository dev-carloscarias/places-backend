namespace Places.Application.Interfaces;

public interface ICurrencyConversion
{
    Task<decimal> Convert(int fromCurrency, int toCurrency, decimal originalValue);
}