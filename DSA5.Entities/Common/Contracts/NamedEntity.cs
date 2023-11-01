namespace DSA5.Entities.Common.Contracts;

public abstract class NamedEntity : BaseEntity
{
    public string Name { get; set; } = null!;
}