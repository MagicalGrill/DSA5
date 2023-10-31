using DSA5.Application.Editor.Base.Commands;
using DSA5.Application.Editor.Base.Queries;
using DSA5.Entities.Common.Contracts;
using DSA5.Host.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DSA5.Host.Editor.EndpointDefinitions;

public abstract class BaseEndpointDefinition<T> : IEndpointDefinition where T : BaseEntity
{
    protected abstract string Prefix { get; }

    public void RegisterEndpoints(WebApplication app)
    {
        var mapGroup = app.MapGroup(Prefix);

        mapGroup.MapGet("/", GetAll);
        mapGroup.MapGet("/{id:guid}", GetById);
        mapGroup.MapPost("/", Create);
        mapGroup.MapPut("/{id:guid}", Update);
        mapGroup.MapDelete("/{id:guid}", Delete);
    }

    protected virtual async Task<IResult> GetAll(IMediator mediator)
    {
        var request = new BaseGetAllRequest<T>();
        var result = await mediator.Send(request);
        return TypedResults.Ok(result);
    }

    protected virtual async Task<IResult> GetById(IMediator mediator, Guid id)
    {
        var request = new BaseGetByIdRequest<T>(id);
        var result = await mediator.Send(request);
        return result is null
            ? TypedResults.NotFound()
            : TypedResults.Ok(result);
    }

    protected virtual async Task<IResult> Create(IMediator mediator, [FromBody] T item)
    {
        var request = new BaseCreateRequest<T>(item);
        var result = await mediator.Send(request);
        return TypedResults.Ok(result);
    }

    protected virtual async Task<IResult> Update(IMediator mediator, T item, Guid id)
    {
        var request = new BaseUpdateRequest<T>(id, item);
        await mediator.Send(request);
        return TypedResults.Ok();
    }

    private async Task<IResult> Delete(IMediator mediator, Guid id)
    {
        var request = new BaseDeleteRequest<T>(id);
        await mediator.Send(request);
        return TypedResults.NoContent();
    }
}