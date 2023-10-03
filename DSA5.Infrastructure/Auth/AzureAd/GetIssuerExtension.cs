using System.Security.Claims;

namespace DSA5.Infrastructure.Auth.AzureAd;

internal static class GetIssuerExtension
{
    internal static string? GetIssuer(this ClaimsPrincipal principal)
    {
        if (principal.FindFirstValue(OpenIdConnectClaimTypes.Issuer) is { } issuer)
        {
            return issuer;
        }

        return principal.FindFirst(AzureAdClaimTypes.ObjectId)?.Issuer;
    }
}