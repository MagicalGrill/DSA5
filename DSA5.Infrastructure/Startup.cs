using System.Reflection;
using DSA5.Infrastructure.Auth;
using DSA5.Infrastructure.Common;
using DSA5.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Infrastructure;

public static class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        return services
            .AddAuth(config)
            .AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()))
            .AddPersistence()
            .AddServices();
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder builder, IConfiguration config) =>
        builder.UseAuthentication()
            .UseCurrentUser()
            .UseAuthorization();
}