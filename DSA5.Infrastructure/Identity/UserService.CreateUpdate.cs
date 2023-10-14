using DSA5.Application.Common.Exceptions;
using DSA5.Application.Identity.Users;
using DSA5.Shared.Authorization;

namespace DSA5.Infrastructure.Identity;

internal sealed partial class UserService : IUserService
{
    public async Task<string> CreateAsync(CreateUserRequest request, string origin)
    {
        var user = new DsaUser
        {
            Email = request.Email,
            UserName = request.UserName,
            ImageUrl = null
        };

        var result = await _userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            throw new InternalServerException("Fehler bei der Validierung", result.GetErrors());
        }

        await _userManager.AddToRoleAsync(user, DsaRoles.Basic);

        var messages = new List<string> { string.Format($"User {user.UserName} wurde registriert.") };

        return string.Join(Environment.NewLine, messages);
    }
}