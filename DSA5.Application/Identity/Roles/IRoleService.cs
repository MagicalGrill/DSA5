namespace DSA5.Application.Identity.Roles;

public interface IRoleService
{
    Task<bool> ExistsAsync(string roleName, string? excludeId);
}