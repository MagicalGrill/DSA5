using Microsoft.AspNetCore.Identity;

namespace DSA5.Infrastructure.Identity;

public sealed class DsaUser : IdentityUser
{
    public string? ImageUrl { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
}