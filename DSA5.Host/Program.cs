using DSA5.Host.HeroGeneration.Handlers;
using DSA5.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
var app = builder.Build();

app.MapGet("/", new PickSpeziesHandler().Handle);

app.Run();