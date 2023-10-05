using Microsoft.AspNetCore.Identity;

namespace DSA5.Infrastructure.Identity;

public sealed class DsaRole : IdentityRole
{
    public string? Description { get; set; }

    public DsaRole(string name, string? descrption = null) : base(name)
    {
        Description = descrption;
        NormalizedName = name.ToUpperInvariant();
    }

    public DsaRole() : base()
    {
    }
}