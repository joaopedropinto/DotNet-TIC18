namespace MinimalApi.Middlewares;
public class ChassiMiddleware
{
    private readonly RequestDelegate _next;
    public ChassiMiddleware(RequestDelegate next){
        _next = next;
    }

    public async Task Invoke(HttpContext context){
        await context.Response.WriteAsync("Montando chassi...\n");
        await _next.Invoke(context);

    }
}

public static class ChassiMiddlewareExtensions{
    public static IApplicationBuilder UseChassiMiddleware(this IApplicationBuilder builder){
        return builder.UseMiddleware<ChassiMiddleware>();
    }
}
