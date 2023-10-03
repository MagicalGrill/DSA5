using System.ComponentModel.DataAnnotations;

namespace DSA5.Application.Common.Persistence;

public sealed class DatabaseSettings : IValidatableObject
{
    public string DbProvider { get; set; } = string.Empty;
    public string ConnectionString { get; set; } = string.Empty;
    
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        if (string.IsNullOrEmpty(DbProvider))
        {
            results.Add(new ValidationResult($"Property {nameof(DbProvider)} is empty."));
        }

        if (string.IsNullOrEmpty(ConnectionString))
        {
            results.Add(new ValidationResult($"Property {nameof(ConnectionString)} is empty."));
        }

        return results;
    }
}