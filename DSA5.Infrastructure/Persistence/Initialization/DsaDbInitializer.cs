using DSA5.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DSA5.Infrastructure.Persistence.Initialization;

internal sealed class DsaDbInitializer
{
    private readonly DsaDbContext _dbContext;
    private readonly DsaDbSeeder _seeder;

    public DsaDbInitializer(DsaDbContext dbContext, DsaDbSeeder seeder)
    {
        _dbContext = dbContext;
        _seeder = seeder;
    }

    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        await SeedDatabaseAsync(cancellationToken);
        
        // if (_dbContext.Database.GetMigrations().Any())
        // {
        //     if ((await _dbContext.Database.GetPendingMigrationsAsync(cancellationToken)).Any())
        //     {
        //         await _dbContext.Database.MigrateAsync(cancellationToken);
        //     }
        //
        //     await SeedDatabaseAsync(cancellationToken);
        // }
    }

    private async Task SeedDatabaseAsync(CancellationToken cancellationToken)
    {
        await _seeder.SeedDatabaseAsync(cancellationToken);
    }
}