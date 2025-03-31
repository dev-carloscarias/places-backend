namespace Places.Api.Middleware;

public class LocalizationMiddleware
{
    private readonly RequestDelegate _next;

    public LocalizationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        if (httpContext == null)
        {
            return;
        }

        var currentLanguage = httpContext.Request.Headers.FirstOrDefault(d => d.Key.ToUpper() == SystemConst.Language).Value;
        if (string.IsNullOrEmpty(currentLanguage)) currentLanguage = "es";
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentLanguage!);

        try
        {
            await _next(httpContext);
        }
        catch (Exception ex) when (!httpContext.Response.HasStarted)
        {
            await httpContext.HandleExceptionAsync(ex);
        }
    }
}