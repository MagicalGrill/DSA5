namespace DSA5.Application.Common.Interfaces;

public interface ICurrentUser
{
    string? Name { get; }
    Guid GetUserId();
}