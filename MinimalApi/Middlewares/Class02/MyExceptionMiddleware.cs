using System.Text.Json;
namespace MinimalApi.Middlewares.Class02;
public class MyExceptionMiddleware
{
    private readonly RequestDelegate _next;
    public MyExceptionMiddleware(RequestDelegate next, string ErrorEndPoint){
        _next = next;
    }

    public async Task Invoke(HttpContext context){
        try{
            await _next(context);
        }
        catch(Exception ex){
            var exceptionDetails = new {
                Message = ex.Message,
                StackTrace = ex.StackTrace,
            };
            var ExceptionJson = JsonSerializer.Serialize(exceptionDetails);
            await context.Response.WriteAsync(ExceptionJson);
            
        }
    }
}
