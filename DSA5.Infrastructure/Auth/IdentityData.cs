using System.Collections.ObjectModel;

namespace DSA5.Infrastructure.Auth;

public static class IdentityData
{
    public static readonly IReadOnlyCollection<(string policyName, string claimName)> PermissionTypes =
        new Collection<(string policyName, string claimName)>
        {
            (AdminUserPolicyName, AdminUserClaimName),
            (GuardianUserPolicyName, GuardianUserClaimName)
        };
    
    public const string AdminUserPolicyName = "Admin";
    public const string AdminUserClaimName = "admin";

    public const string GuardianUserPolicyName = "Guardian";
    public const string GuardianUserClaimName = "guardian";
}