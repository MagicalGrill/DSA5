using DSA5.Application.Common.Exceptions;
using DSA5.Infrastructure.Identity;
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

    public async Task SeedDatabaseAsync(CancellationToken cancellationToken)
    {
        await SeedRolesAsync();
        await SeedUsersAsync();
        await AssignRolesAsync();
    }

    private async Task SeedRolesAsync()
    {
        foreach (var roleName in DsaRoles.DefaultRoles)
        {
            var role = await _roleManager.Roles.SingleOrDefaultAsync(r => r.Name!.Equals(roleName));
            if (role is not null) continue;
            role = new DsaRole(roleName);
            await _roleManager.CreateAsync(role);
        }
    }

    private async Task SeedUsersAsync()
    {
        const string password = "Hosenbein";
        var admin = new DsaUser
        {
            UserName = "Admin",
            Email = "sith@admin.com"
        };

        if (await _userManager.FindByNameAsync(admin.UserName) is null)
        {
            await _userManager.CreateAsync(admin, password);
        }
    }

    private async Task AssignRolesAsync()
    {
        var admin = await _userManager.FindByNameAsync("Admin");
        if (admin is null)
        {
            throw new NotFoundException("Benutzer 'Admin' wurde nicht gefunden.");
        }

        await _userManager.AddToRolesAsync(admin, DsaRoles.DefaultRoles);
    }
}