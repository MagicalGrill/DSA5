using System.Collections.ObjectModel;

namespace DSA5.Shared.Authorization;

public static class DsaRoles
{
    public const string Admin = nameof(Admin);
    public const string Basic = nameof(Basic);

    public static IEnumerable<string> DefaultRoles { get; } = new ReadOnlyCollection<string>(new[]
    {
        Admin,
        Basic
    });

    public static bool IsDefault(string roleName) => DefaultRoles.Any(r => r.Equals(roleName));
}