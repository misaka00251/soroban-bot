using soroban_bot.Services;

// Load appsettings.json and environment variables
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton(new GitHubService(
    builder.Configuration.GetValue<int>("GitHubApp:AppId"),
    builder.Configuration["GitHubApp:PrivateKey"]!,
    builder.Configuration.GetValue<long>("GitHubApp:InstallationId")
));

var app = builder.Build();
app.MapControllers();
app.Run();
