using DSA5.Application.Identity.Users;
using DSA5.Application.Identity.Users.UpdateUser;
using DSA5.Host.Abstractions;
using DSA5.Infrastructure.Auth;
using Microsoft.AspNetCore.Mvc;

namespace DSA5.Host.Identity.EndpointDefinitions;

public class ManageUserDefinitions : IEndpointDefinition
{
    public void RegisterEndpoints(WebApplication app)
    {
        var users = app.MapGroup("Users");
        
        users.MapPatch("/", Update)
            .WithName(nameof(Update))
            .RequireAuthorization();

        users.MapPost("/", Register)
            .WithName(nameof(Register))
            .RequireAuthorization(IdentityData.AdminUserPolicyName);

        users.MapDelete("/{id}", Delete)
            .WithName(nameof(Delete))
            .RequireAuthorization(IdentityData.AdminUserPolicyName);
    }

    private async Task<IResult> Register(IUserService userService, [FromBody] CreateUserRequest request)
    {
        var result = await userService.CreateAsync(request);
        return Results.Ok(result);
    }

    private async Task<IResult> Update(IUserService userService, [FromBody] UpdateUserRequest request)
    {
        await userService.UpdateAsync(request);
        return Results.Ok();
    }

    private async Task<IResult> Delete(IUserService userService, string id)
    {
        await userService.DeleteAsync(id);
        return Results.Ok();
    }
}