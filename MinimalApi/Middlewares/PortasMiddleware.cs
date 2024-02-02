namespace MinimalApi.Middlewares;
public class PortasMiddleware
{
    private readonly RequestDelegate _next;
    public PortasMiddleware(RequestDelegate next){
        _next = next;
    }

    public async Task Invoke(HttpContext context){
        await context.Response.WriteAsync("Ajustando portas...\n");
        await _next.Invoke(context);

    }
}
public static class PortasMiddlewareExtensions{
    public static IApplicationBuilder UsePortasMiddleware(this IApplicationBuilder builder){
        return builder.UseMiddleware<PortasMiddleware>();
    }
}