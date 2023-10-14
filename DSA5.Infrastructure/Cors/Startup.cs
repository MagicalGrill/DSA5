using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Infrastructure.Common.Settings;

internal static class Startup
{
    private const string CorsPolicy = nameof(CorsPolicy);

    internal static IServiceCollection AddCorsPolicy(this IServiceCollection services, IConfiguration config)
    {
        var corsSettings = config.GetSection(nameof(CorsSettings)).Get<CorsSettings>();
        if (corsSettings is null) return services;
        var origins = new List<string>();
        if (corsSettings.Angular is not null)
        {
            origins.Add(corsSettings.Angular);
        }

        return services.AddCors(options => options.AddPolicy(CorsPolicy, policy =>
            policy.AllowAnyHeader()
                .AllowAnyMethod()
                .WithOrigins(origins.ToArray())));
    }

    internal static IApplicationBuilder UseCorsPolicy(this IApplicationBuilder app) =>
        app.UseCors(CorsPolicy);
}