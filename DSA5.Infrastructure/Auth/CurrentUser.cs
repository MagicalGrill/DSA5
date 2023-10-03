using System.Security.Claims;
using DSA5.Application.Common.Interfaces;
using DSA5.Shared.Authorization;

namespace DSA5.Infrastructure.Auth;

public class CurrentUser : ICurrentUser, ICurrentUserInitializer
{
    private ClaimsPrincipal? _user;

    public string? Name => _user?.Identity?.Name;

    private Guid _userId = Guid.Empty;

    public Guid GetUserId() => IsAuthenticated()
        ? Guid.Parse(_user?.GetUserId() ?? Guid.Empty.ToString())
        : _userId;

    private bool IsAuthenticated() => _user?.Identity?.IsAuthenticated is true;
    public void SetCurrentUser(ClaimsPrincipal user)
    {
        if (_user != null)
        {
            throw new Exception("Method reserved for in-scope initialization");
        }

        _user = user;
    }

    public void SetCurrentUserId(string userId)
    {
        if (_userId != Guid.Empty)
        {
            throw new Exception("Method reserved for in-scope initialization");
        }

        if (!string.IsNullOrEmpty(userId))
        {
            _userId = Guid.Parse(userId);
        }
    }
}