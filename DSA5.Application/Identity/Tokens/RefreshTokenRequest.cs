namespace DSA5.Application.Identity.Tokens;

public sealed record RefreshTokenRequest(string Token, string RefreshToken);