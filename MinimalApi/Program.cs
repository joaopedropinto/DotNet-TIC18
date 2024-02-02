using MinimalApi.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

// app.UseMiddleware<ChassiMiddleware>();
// app.UseMiddleware<MotorMiddleware>();
// app.UseMiddleware<PortasMiddleware>();
// app.UseMiddleware<PinturaMiddleware>();
// app.UseMiddleware<InternoMiddleware>();

// app.UseChassiMiddleware();
// app.UseMotorMiddleware();
// app.UsePortasMiddleware();
// app.UsePinturaMiddleware();
// app.UseInternoMiddleware();

app.Run(async context =>
{
    await context.Response.WriteAsync("\n");
});

app.Run();
