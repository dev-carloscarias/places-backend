namespace Places.Api.Middleware;

public class GlobalValuesMiddleware
{
    private readonly RequestDelegate _next;

    private readonly IGlobalValuesAccessor _globalValuesAccessor;

    public GlobalValuesMiddleware(RequestDelegate next, IGlobalValuesAccessor globalValuesAccessor)
    {
        _next = next;
        _globalValuesAccessor = globalValuesAccessor;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        if (httpContext == null)
        {
            return;
        }

        var currentCurrency = httpContext.Request.Headers.FirstOrDefault(d => d.Key == SystemConst.Currency).Value;
        if (string.IsNullOrEmpty(currentCurrency)) currentCurrency = _globalValuesAccessor.GetCurrency().ToString();

        // Modificar el valor global si es necesario
        _globalValuesAccessor.SetCurrency(Convert.ToInt32(currentCurrency));

        // Continuar con la siguiente pieza de middleware
        await _next(httpContext);
    }
}