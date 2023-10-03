namespace DSA5.Entities.Common.Contracts;

public interface IEntity
{
    Guid Id { get; set; }
    DateTime Created { get; set; }
    DateTime LastUpdated { get; set; }
}