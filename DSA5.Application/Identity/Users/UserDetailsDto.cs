namespace DSA5.Application.Identity.Users;

public sealed class UserDetailsDto
{
    public string Id { get; set; } = null!;
    public string? Username { get; set; }
    public string? Email { get; set; }
    public bool IsActive { get; set; }
    public bool EmailConfirmed { get; set; }
    public string? ImageUrl { get; set; }
}