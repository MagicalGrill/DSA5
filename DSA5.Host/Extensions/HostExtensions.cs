using DSA5.Application;
using DSA5.Host.Abstractions;
using DSA5.Infrastructure;

namespace DSA5.Host.Extensions;

public static class HostExtensions
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddInfrastructure(builder.Configuration);
        builder.Services.AddApplication();
    }

    public static void RegisterEndpointDefinitions(this WebApplication app)
    {
        var endpointDefinitions = typeof(Program).Assembly
            .GetTypes()
            .Where(t => t.IsAssignableTo(typeof(IEndpointDefinition))
                        && !t.IsAbstract && !t.IsInterface)
            .Select(Activator.CreateInstance)
            .Cast<IEndpointDefinition>();

        foreach (var endpointDefinition in endpointDefinitions)
        {
            endpointDefinition.RegisterEndpoints(app);
        }
    }
}