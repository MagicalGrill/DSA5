using DSA5.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Infrastructure.Identity;

internal static class Startup
{
    internal static IServiceCollection AddIdentity(this IServiceCollection services) =>
        services.AddIdentity<DsaUser, DsaRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<DsaDbContext>()
            .AddDefaultTokenProviders()
            .Services;
}