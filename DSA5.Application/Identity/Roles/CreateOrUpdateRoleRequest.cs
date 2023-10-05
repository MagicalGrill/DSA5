namespace DSA5.Application.Identity.Roles;

public sealed record CreateOrUpdateRoleRequest(string? Id, string Name, string? Description);