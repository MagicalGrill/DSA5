using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Web;

namespace DSA5.Infrastructure.Auth.AzureAd;

internal static class Startup
{
    internal static IServiceCollection AddAzureAdAuth(this IServiceCollection services, IConfiguration config)
    {
        services.AddAuthorization(
                options =>
                {
                    foreach (var (policy, claim) in IdentityData.PermissionTypes)
                    {
                        options.AddPolicy(policy, cfg => cfg.RequireClaim(claim, "true"));
                    }
                }
            )
            .AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddMicrosoftIdentityWebApi(
                jwtOptions => jwtOptions.Events = new AzureAdJwtBearerEvents(config),
                msIdentityOptions => config.GetSection("SecuritySettings:AzureAd").Bind(msIdentityOptions));

        return services;
    }
}