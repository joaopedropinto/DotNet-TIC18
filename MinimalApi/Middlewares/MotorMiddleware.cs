namespace MinimalApi.Middlewares;
public class MotorMiddleware   
{
    private readonly RequestDelegate _next;
    public MotorMiddleware(RequestDelegate next){
        _next = next;
    }

    public async Task Invoke(HttpContext context){
        await context.Response.WriteAsync("Aclopando motor...\n");
        await _next.Invoke(context);

    }
}

public static class MotorMiddlewareExtensions{
    public static IApplicationBuilder UseMotorMiddleware(this IApplicationBuilder builder){
        return builder.UseMiddleware<MotorMiddleware>();
    }
}
