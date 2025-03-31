namespace Places.Application.Services;

public class CurrencyConversion : ICurrencyConversion
{
    private readonly ICurrencyRepository _currencyRepository;

    public CurrencyConversion(ICurrencyRepository currencyRepository)
    {
        _currencyRepository = currencyRepository;
    }

    public async Task<decimal> Convert(int fromCurrency, int toCurrency, decimal originalValue)
    {
        var currencyFrom = await _currencyRepository.GetByIdAsync(fromCurrency);
        var currencyTo = await _currencyRepository.GetByIdAsync(toCurrency);

        if (currencyFrom == null || currencyTo == null)
        {
            return System.Convert.ToInt32(originalValue);
        }
        var convertedValue = (originalValue / currencyFrom.Rate) * currencyTo.Rate;
        return Math.Round(convertedValue, 2);

    }
}