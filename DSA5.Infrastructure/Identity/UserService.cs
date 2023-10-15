using DSA5.Application.Identity.Users;
using DSA5.Infrastructure.Auth;
using DSA5.Infrastructure.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace DSA5.Infrastructure.Identity;

internal sealed partial class UserService : IUserService
{
    private readonly SignInManager<DsaUser> _signInManager;
    private readonly UserManager<DsaUser> _userManager;
    private readonly RoleManager<DsaRole> _roleManager;
    private readonly DsaDbContext _dbContext;
    private readonly SecuritySettings _securitySettings;

    public UserService(
        SignInManager<DsaUser> signInManager,
        UserManager<DsaUser> userManager,
        RoleManager<DsaRole> roleManager,
        DsaDbContext dbContext,
        IOptions<SecuritySettings> securitySettings)
    {
        _signInManager = signInManager;
        _userManager = userManager;
        _roleManager = roleManager;
        _dbContext = dbContext;
        _securitySettings = securitySettings.Value;
    }

    public async Task<bool> ExistsWithEmailAsync(string email)
    {
        return await _userManager.FindByEmailAsync(email) is not null;
    }
}