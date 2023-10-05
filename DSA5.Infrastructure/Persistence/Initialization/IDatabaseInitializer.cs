namespace DSA5.Infrastructure.Persistence.Initialization;

internal interface IDatabaseInitializer
{
    Task InitializeDatabaseAsync(CancellationToken cancellationToken);
}