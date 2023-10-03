using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Application;

public static class Startup
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        return services;
    }
}