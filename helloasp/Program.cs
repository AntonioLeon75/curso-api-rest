internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMvc();
        builder.Services.AddTransient<ISaluteService, SaluteService>();
        var app = builder.Build();

        app.MapControllers();

        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}
