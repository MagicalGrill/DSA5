using System.Collections.ObjectModel;

namespace DSA5.Shared.Authorization;

public static class DsaRoles
{
    public const string Admin = nameof(Admin);
    public const string Basic = nameof(Basic);
    public const string Guardian = nameof(Guardian);

    public static IEnumerable<string> DefaultRoles { get; } = new ReadOnlyCollection<string>(new[]
    {
        Admin,
        Guardian,
        Basic
    });
}