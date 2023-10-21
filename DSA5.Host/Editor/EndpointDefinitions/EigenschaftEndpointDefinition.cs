using DSA5.Application.Editor.Eigenschaften.Commands;
using DSA5.Application.Editor.Eigenschaften.Queries;
using DSA5.Entities.Welt;
using DSA5.Host.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class EigenschaftEndpointDefinition : IEndpointDefinition
{
    public void RegisterEndpoints(WebApplication app)
    {
        var mapGroup = app.MapGroup("/editor/eigenschaften");

        mapGroup.MapGet("/", GetEigenschaften)
            .WithName(nameof(GetEigenschaften));

        mapGroup.MapGet("/{id:guid}", GetEigenschaftById)
            .WithName(nameof(GetEigenschaftById));

        mapGroup.MapPost("/", CreateEigenschaft)
            .WithName(nameof(CreateEigenschaft));

        mapGroup.MapPut("/{id:guid}", UpdateEigenschaft)
            .WithName(nameof(UpdateEigenschaft));

        mapGroup.MapDelete("/{id:guid}", DeleteEigenschaft)
            .WithName(nameof(DeleteEigenschaft));
    }

    private async Task<IResult> GetEigenschaften(IMediator mediator)
    {
        var request = new GetEigenschaftenRequest();
        var result = await mediator.Send(request);
        return TypedResults.Ok(result);
    }

    private async Task<IResult> GetEigenschaftById(IMediator mediator, Guid id)
    {
        var request = new GetEigenschaftByIdRequest(id);
        var result = await mediator.Send(request);
        return result is null
            ? TypedResults.NotFound()
            : TypedResults.Ok(result);
    }

    private async Task<IResult> CreateEigenschaft(IMediator mediator, [FromBody] Eigenschaft eigenschaft)
    {
        var request = new CreateEigenschaftRequest(eigenschaft);
        var result = await mediator.Send(request);
        return TypedResults.Ok(result);
    }

    private async Task<IResult> UpdateEigenschaft(IMediator mediator, Eigenschaft eigenschaft, Guid id)
    {
        var request = new UpdateEigenschaftRequest(id, eigenschaft);
        await mediator.Send(request);
        return TypedResults.Ok();
    }

    private async Task<IResult> DeleteEigenschaft(IMediator mediator, Guid id)
    {
        var request = new DeleteEigenschaftRequest(id);
        await mediator.Send(request);
        return TypedResults.NoContent();
    }
}