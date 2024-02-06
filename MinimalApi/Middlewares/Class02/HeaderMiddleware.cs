namespace MinimalApi.Middlewares.Class02;
public class HeaderMiddleware
{
    private readonly RequestDelegate _next;
    public HeaderMiddleware(RequestDelegate next){
        _next = next;
    }
    public async Task Invoke(HttpContext context){
        string headerValue = $"{DateTime.UtcNow:yyyy-MM-ddTHH:mm:ss.fffZ} - IP:{context.Connection.RemoteIpAddress}";
        context.Response.Headers.Add("Custom-Header", headerValue);
        
        await _next(context);
    }
}
