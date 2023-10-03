using DSA5.Host.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.RegisterServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World");
app.RegisterEndpointDefinitions();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));

app.Run();