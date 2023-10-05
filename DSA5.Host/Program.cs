using DSA5.Host.Configurations;
using DSA5.Host.Extensions;
using DSA5.Infrastructure;
using DSA5.Infrastructure.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);
builder.AddConfigurations();
builder.RegisterServices();

// Temporary Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new() { Title = "DSA5 API", Version = "v1" }));

var app = builder.Build();

await app.Services.InitializeDatabasesAsync();

app.UseInfrastructure(builder.Configuration);
app.RegisterEndpointDefinitions();

// Temporary Swagger
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));

app.Run();