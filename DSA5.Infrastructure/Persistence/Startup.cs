﻿using DSA5.Application.Common.Persistence;
using DSA5.Infrastructure.Persistence.Context;
using DSA5.Infrastructure.Persistence.Initialization;
using DSA5.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace DSA5.Infrastructure.Persistence;

internal static class Startup
{
    internal static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services
            .AddOptions<DatabaseSettings>()
            .BindConfiguration(nameof(DatabaseSettings));

        return services.AddDbContext<DsaDbContext>((provider, optionsBuilder) =>
            {
                var databaseSettings = provider.GetRequiredService<IOptions<DatabaseSettings>>().Value;
                optionsBuilder.UseDatabase(databaseSettings.ConnectionString);
            })
            .AddTransient<IDatabaseInitializer, DatabaseInitializer>()
            .AddTransient<DsaDbInitializer>()
            .AddTransient<DsaDbSeeder>()
            .AddRepositories();
    }

    private static DbContextOptionsBuilder UseDatabase(this DbContextOptionsBuilder builder, string connectionString)
    {
        return builder.UseNpgsql(connectionString);
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
        => services.AddScoped(typeof(IRepository<>), typeof(DsaRepository<>));
}