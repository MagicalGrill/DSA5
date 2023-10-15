using DSA5.Application.Common.Exceptions;
using DSA5.Application.Identity.Users;
using DSA5.Application.Identity.Users.UpdateUser;
using DSA5.Shared.Authorization;
using Microsoft.AspNetCore.Identity;

namespace DSA5.Infrastructure.Identity;

internal sealed partial class UserService : IUserService
{
    public async Task<string> CreateAsync(CreateUserRequest request)
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

    public async Task UpdateAsync(UpdateUserRequest request)
    {
        var user = await _userManager.FindByIdAsync(request.Id);
        if (user is null)
        {
            throw new NotFoundException("Benutzer nicht gefunden.");
        }

        IdentityResult? result;
        if (!string.IsNullOrEmpty(request.NewPassword))
        {
            result = await _userManager.ChangePasswordAsync(user, request.OldPassword, request.NewPassword);
            if (result.Succeeded)
            {
                throw new InternalServerException("Fehler bei der Validierung des neuen Passworts", result.GetErrors());
            }
        }

        var imageUrl = string.IsNullOrWhiteSpace(request.ImageUrl) ? user.ImageUrl : request.ImageUrl;

        user.UserName = request.UserName;
        result = await _userManager.UpdateAsync(user);

        if (!result.Succeeded)
        {
            throw new InternalServerException("Update fehlgeschlagen", result.GetErrors());
        }
    }

    public async Task DeleteAsync(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user is null)
        {
            throw new NotFoundException("Benutzer nicht gefunden.");
        }

        var result = await _userManager.DeleteAsync(user);

        if (!result.Succeeded)
        {
            throw new InternalServerException("Benutzer konnte nicht entfernt werden", result.GetErrors());
        }
    }
}