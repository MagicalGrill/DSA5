namespace DSA5.Entities.Common.Contracts;

public abstract class BaseEntity : IEntity
{
    public BaseEntity()
    {
        Created = DateTime.Now;
        LastUpdated = Created;
    }
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastUpdated { get; set; }
}