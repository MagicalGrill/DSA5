using DSA5.Application.Identity.Users;
using DSA5.Host.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace DSA5.Host.Identity.EndpointDefinitions;

public class UserEndpointDefinition : IEndpointDefinition
{
    public void RegisterEndpoints(WebApplication app)
    {
        var users = app.MapGroup("Users");

        users.MapPost("/", SelfRegister)
            .WithName(nameof(SelfRegister));
    }
    
    private async Task<IResult> SelfRegister(HttpContext httpContext, IUserService userService, [FromBody] CreateUserRequest request)
    {
        var result = await userService.CreateAsync(request, GetOriginFromRequest(httpContext));
        return Results.Ok(result);
    }

    private static string GetOriginFromRequest(HttpContext httpContext)
    {
        var request = httpContext.Request;
        return $"{request.Scheme}://{request.Host.Value}{request.PathBase.Value}";
    }
}