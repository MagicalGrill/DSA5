namespace DSA5.Application.Identity.Roles;

public sealed record UpdateRolePermissionsRequest(string RoleId, List<string> Permissions);

