using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DSA5.Infrastructure.Persistence.Context.ValueConverters;

internal sealed class UtcValueConverter : ValueConverter<DateTime, DateTime>
{
    public UtcValueConverter() : base(v => DateTime.SpecifyKind(v, DateTimeKind.Utc), v => v)
    {
    }
}