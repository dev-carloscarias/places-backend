namespace Places.Application.Interfaces;

public interface IGlobalValuesAccessor
{
    int GetCurrency();

    void SetCurrency(int value);
}