using DSA5.Application.Identity.Tokens;
using DSA5.Host.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace DSA5.Host.Identity.EndpointDefinitions;

public sealed class TokenEndpointDefinitions : IEndpointDefinition
{
    public void RegisterEndpoints(WebApplication app)
    {
        var users = app.MapGroup("Auth");
        users.MapPost("/", Login)
            .WithName(nameof(Login));
    }
    
    private async Task<IResult> Login(ITokenService tokenService, [FromBody] TokenRequest request)
    {
        var response = await tokenService.GetTokenAsync(request);
        return Results.Ok(response);
    }
}