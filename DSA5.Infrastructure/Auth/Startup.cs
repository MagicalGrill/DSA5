using DSA5.Application.Common.Interfaces;
using DSA5.Infrastructure.Auth.AzureAd;
using DSA5.Infrastructure.Auth.Jwt;
using DSA5.Infrastructure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Infrastructure.Auth;

internal static class Startup
{
    internal static IServiceCollection AddAuth(this IServiceCollection services, IConfiguration config)
    {
        services.AddCurrentUser()
            .AddIdentity();

        services.Configure<SecuritySettings>(config.GetSection(nameof(SecuritySettings)));
        return config["SecuritySettings:Provider"]!.Equals("AzureAd", StringComparison.OrdinalIgnoreCase)
            ? services.AddAzureAdAuth(config)
            : services.AddJwtAuth();
    }

    internal static IApplicationBuilder UseCurrentUser(this IApplicationBuilder app) =>
        app.UseMiddleware<CurrentUserMiddleware>();

    private static IServiceCollection AddCurrentUser(this IServiceCollection services) =>
        services.AddScoped<CurrentUserMiddleware>()
            .AddScoped<ICurrentUser, CurrentUser>()
            .AddScoped(sp => (ICurrentUserInitializer)sp.GetRequiredService<ICurrentUser>());
}