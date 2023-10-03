using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Application;

public static class Startup
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services
            .AddMediatR(configuration => configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}