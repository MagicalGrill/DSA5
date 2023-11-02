using DSA5.Application.Editor.Base.Queries;
using DSA5.Application.Editor.Kampftechniken.Specs;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class KampftechnikEndpointDefinition : BaseEndpointDefinition<Kampftechnik>
{
    public override void RegisterEndpoints(WebApplication app)
    {
        var mapGroup = app.MapGroup(Prefix);
        mapGroup.MapGet("/getAllComplete", GetAllComplete);
        base.RegisterEndpoints(app);
    }

    protected override string Prefix => "/editor/kampftechniken";

    private static async Task<IResult> GetAllComplete(IMediator mediator, CancellationToken cancellationToken)
    {
        var spec = new KampftechnikCompleteSpec();
        var request = new BaseGetBySpecRequest<Kampftechnik>(spec);
        var result = await mediator.Send(request, cancellationToken);
        return TypedResults.Ok(result);
    }
}