using DSA5.Application.Common.Interfaces;

namespace DSA5.Application.Identity.Tokens;

public interface ITokenService : ITransientService
{
    Task<TokenResponse> GetTokenAsync(TokenRequest request);

    Task<TokenResponse> RefreshTokenAsync(RefreshTokenRequest request);
}