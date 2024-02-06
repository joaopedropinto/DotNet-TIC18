using MinimalApi.Middlewares.Class02;
namespace Middlewares.Class02.Extensions{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseAddHeaderMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HeaderMiddleware>();
        }
        public static IApplicationBuilder UseTimerMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<TimerMiddleware>();
        }
        public static IApplicationBuilder UseMyExceptionMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyExceptionMiddleware>();
        }
    }

}
