using DSA5.Application.Editor.Base.Queries;
using DSA5.Application.Editor.Geweihtentraditionen.Specs;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class GeweihteTraditionenEndpointDefinition : BaseEndpointDefinition<Geweihtentradition>
{
    protected override string Prefix => "/editor/geweihtentraditionen";


    protected override async Task<IResult> GetAll(IMediator mediator)
    {
        var spec = new TraditionMitAspektenSpec();
        var request = new BaseGetBySpecRequest<Geweihtentradition>(spec);
        var result = await mediator.Send(request);
        return TypedResults.Ok(result);
    }
}