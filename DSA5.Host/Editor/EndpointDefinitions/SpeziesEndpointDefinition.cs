using DSA5.Application.Editor.BaseEntities.Rassen.Commands;
using DSA5.Application.Editor.BaseEntities.Rassen.Queries;
using DSA5.Entities.Welt;
using DSA5.Host.Abstractions;
using DSA5.Host.Editor.Filters;
using MediatR;

namespace DSA5.Host.Editor.EndpointDefinitions;

public class SpeziesEndpointDefinition : IEndpointDefinition
{
    public void RegisterEndpoints(WebApplication app)
    {
        var spezies = app.MapGroup("/editor/spezies");
        
        spezies.MapGet("/", GetAllSpezies)
            .WithName(nameof(GetAllSpezies));

        spezies.MapGet("/{id:guid}", GetSpeziesById)
            .WithName(nameof(GetSpeziesById));

        spezies.MapPost("/", CreateSpezies)
            .WithName(nameof(CreateSpezies))
            .AddEndpointFilter<SpeziesValidationFilter>();

        spezies.MapPut("/{id:guid}", UpdateSpezies)
            .WithName(nameof(UpdateSpezies))
            .AddEndpointFilter<SpeziesValidationFilter>();

        spezies.MapDelete("/{id:guid}", DeleteSpezies)
            .WithName(nameof(DeleteSpezies));
    }

    private async Task<IResult> GetAllSpezies(IMediator mediator)
    {
        var getAllSpezies = new GetAllSpezies();
        var spezies = await mediator.Send(getAllSpezies);
        return TypedResults.Ok(spezies);
    }

    private async Task<IResult> GetSpeziesById(IMediator mediator, Guid id)
    {
        var getSpezies = new GetSpeziesById { Id = id };
        var spezies = await mediator.Send(getSpezies);
        return TypedResults.Ok(spezies);
    }

    private async Task<IResult> CreateSpezies(IMediator mediator, Spezies spezies)
    {
        var createSpezies = new CreateSpezies
        {
            ApKosten = spezies.ApKosten,
            Beschreibung = spezies.Beschreibung,
            Geschwindigkeit = spezies.Geschwindigkeit,
            Lebenspunkte = spezies.Lebenspunkte,
            Name = spezies.Name,
            Seelenkraft = spezies.Seelenkraft,
            Zaehigkeit = spezies.Zaehigkeit
        };
        var createdSpezies = await mediator.Send(createSpezies);
        return Results.CreatedAtRoute(nameof(GetSpeziesById), new { createdSpezies.Id }, createdSpezies);
    }

    private async Task<IResult> UpdateSpezies(IMediator mediator, Spezies spezies, Guid id)
    {
        var updateSpezies = new UpdateSpezies { Id = id, UpdatedSpezies = spezies };
        var guid = await mediator.Send(updateSpezies);
        return TypedResults.Ok(guid);
    }

    private async Task<IResult> DeleteSpezies(IMediator mediator, Guid id)
    {
        var deleteSpezies = new DeleteSpezies { Id = id };
        await mediator.Send(deleteSpezies);
        return TypedResults.NoContent();
    }
}