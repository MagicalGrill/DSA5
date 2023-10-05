namespace DSA5.Application.Identity.Roles;

public sealed class RoleDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public List<string>? Permissions { get; set; }
}