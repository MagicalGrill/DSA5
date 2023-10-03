using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;

namespace DSA5.Infrastructure.Auth.AzureAd;

internal class AzureAdJwtBearerEvents : JwtBearerEvents
{
    private readonly IConfiguration _configuration;

    public AzureAdJwtBearerEvents(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public override async Task TokenValidated(TokenValidatedContext context)
    {
        var principal = context.Principal;
        var issuer = principal?.GetIssuer();
    }
}