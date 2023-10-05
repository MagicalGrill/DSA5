using Microsoft.AspNetCore.Identity;

namespace DSA5.Infrastructure.Identity;

internal static class IdentityResultExtensions
{
    internal static List<string> GetErrors(this IdentityResult result)
        => result.Errors.Select(e => e.Description).ToList();
}