using DSA5.Application.Editor.Rassen.Commands;
using DSA5.Application.Editor.Rassen.Queries;
using DSA5.Entities.Welt;
using DSA5.Host.Abstractions;
using DSA5.Host.Editor.Filters;
using MediatR;

namespace DSA5.Host.Editor.EndpointDefinitions;

public class SpeziesEndpointDefinition : IEndpointDefinition
{
    public void RegisterEndpoints(WebApplication app)
    {
        var mapGroup = app.MapGroup("/editor/spezies");

        mapGroup.MapGet("/", GetSpezies)
            .WithName(nameof(GetSpezies));

        mapGroup.MapGet("/{id:guid}", GetSpeziesById)
            .WithName(nameof(GetSpeziesById));

        mapGroup.MapPost("/", CreateSpezies)
            .WithName(nameof(CreateSpezies))
            .AddEndpointFilter<SpeziesValidationFilter>();

        mapGroup.MapPut("/{id:guid}", UpdateSpezies)
            .WithName(nameof(UpdateSpezies))
            .AddEndpointFilter<SpeziesValidationFilter>();

        mapGroup.MapDelete("/{id:guid}", DeleteSpezies)
            .WithName(nameof(DeleteSpezies));
    }

    private async Task<IResult> GetSpezies(IMediator mediator)
    {
        var request = new GetSpeziesRequest();
        var result = await mediator.Send(request);
        return TypedResults.Ok(result);
    }

    private async Task<IResult> GetSpeziesById(IMediator mediator, Guid id)
    {
        var request = new GetSpeziesByIdRequest(id);
        var result = await mediator.Send(request);
        return result is null
            ? TypedResults.NotFound()
            : TypedResults.Ok(result);
    }

    private async Task<IResult> CreateSpezies(IMediator mediator, Spezies spezies)
    {
        var request = new CreateSpeziesRequest(spezies);
        var result = await mediator.Send(request);
        return Results.CreatedAtRoute(nameof(GetSpeziesById), new { result.Id }, result);
    }

    private async Task<IResult> UpdateSpezies(IMediator mediator, Spezies spezies, Guid id)
    {
        var request = new UpdateSpeziesRequest(id, spezies);
        await mediator.Send(request);
        return TypedResults.Ok();
    }

    private async Task<IResult> DeleteSpezies(IMediator mediator, Guid id)
    {
        var request = new DeleteSpeziesRequest(id);
        await mediator.Send(request);
        return TypedResults.NoContent();
    }
}