namespace DSA5.Entities.Common.Contracts;

public interface IEntity<out TId>
{
    TId Id { get; }
}