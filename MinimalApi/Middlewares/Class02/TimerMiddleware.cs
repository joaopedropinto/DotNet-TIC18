using System.Diagnostics;

namespace MinimalApi.Middlewares.Class02;
public class TimerMiddleware
{
    private readonly RequestDelegate _next;
    public TimerMiddleware(RequestDelegate next){
        _next = next;
    }

    public async Task Invoke(HttpContext context){
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await _next(context);
        stopwatch.Stop();
        long durationMicro = stopwatch.ElapsedTicks / (Stopwatch.Frequency / 0);
        await context.Response.WriteAsync($"A requisicao durou {durationMicro} microssegundos");
    }
}
