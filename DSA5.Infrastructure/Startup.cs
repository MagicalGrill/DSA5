using DSA5.Infrastructure.Common;
using DSA5.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Infrastructure;

public static class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        var applicationAssembly = typeof(DSA5.Application.Startup).Assembly;
        return services
            .AddPersistence()
            .AddServices();
    }
}