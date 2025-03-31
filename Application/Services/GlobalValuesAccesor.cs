using Microsoft.Extensions.Options;

namespace Places.Application.Services;

public class GlobalValuesAccessor : IGlobalValuesAccessor
{
    private readonly GlobalValues _globalValuesInstance;

    public GlobalValuesAccessor(IOptions<GlobalValues> globalValues)
    {
        _globalValuesInstance = globalValues.Value;
    }

    public int GetCurrency()
    {
        return _globalValuesInstance.CurrencyId;
    }

    public void SetCurrency(int value)
    {
        _globalValuesInstance.CurrencyId = value;
    }
}