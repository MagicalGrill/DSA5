namespace DSA5.Entities.Common.Contracts;

public abstract class DescriptedEntity : BaseEntity
{
    public string Name { get; set; } = null!;
    public string? Beschreibung { get; set; }
}