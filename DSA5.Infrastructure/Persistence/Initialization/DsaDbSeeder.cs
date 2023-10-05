using DSA5.Infrastructure.Identity;
using DSA5.Infrastructure.Persistence.Context;
using DSA5.Shared.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DSA5.Infrastructure.Persistence.Initialization;

internal class DsaDbSeeder
{
    private readonly RoleManager<DsaRole> _roleManager;
    private readonly UserManager<DsaUser> _userManager;

    public DsaDbSeeder(RoleManager<DsaRole> roleManager, UserManager<DsaUser> userManager)
    {
        _roleManager = roleManager;
        _userManager = userManager;
    }

    public async Task SeedDatabaseAsync(DsaDbContext dbContext, CancellationToken cancellationToken)
    {
        await SeedRolesAsync(dbContext);
    }

    private async Task SeedRolesAsync(DsaDbContext dbContext)
    {
        foreach (var roleName in DsaRoles.DefaultRoles)
        {
            var role = await _roleManager.Roles.SingleOrDefaultAsync(r => r.Name!.Equals(roleName));
            if (role is not null) continue;
            role = new DsaRole(roleName);
            await _roleManager.CreateAsync(role);
        }
    }
}