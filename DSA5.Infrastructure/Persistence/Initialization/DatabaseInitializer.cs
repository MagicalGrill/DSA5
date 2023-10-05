using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Infrastructure.Persistence.Initialization;

public class DatabaseInitializer : IDatabaseInitializer
{
    private readonly IServiceProvider _serviceProvider;

    public DatabaseInitializer(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task InitializeDatabaseAsync(CancellationToken cancellationToken)
    {
        using var scope = _serviceProvider.CreateScope();

        await scope.ServiceProvider.GetRequiredService<DsaDbInitializer>()
            .InitializeAsync(cancellationToken);
    }
}