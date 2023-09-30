namespace DSA5.Entities.Common.Contracts;

public abstract class BaseEntity : BaseEntity<int>
{
}

public abstract class BaseEntity<TId> : IEntity<TId>
{
    public TId Id { get; set; } = default!;
}