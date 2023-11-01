using DSA5.Application.Editor.Base.Queries;
using DSA5.Application.Editor.Talente.Specs;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class TalentEndpointDefinition : BaseEndpointDefinition<Talent>
{
    protected override string Prefix => "/editor/talente";

    public override void RegisterEndpoints(WebApplication app)
    {
        base.RegisterEndpoints(app);

        var mapGroup = app.MapGroup(Prefix);
        mapGroup.MapGet("/getAllComplete/", GetAllComplete);
    }

    private static async Task<IResult> GetAllComplete(IMediator mediator, CancellationToken cancellationToken)
    {
        var spec = new TalentCompleteSpec();
        var request = new BaseGetBySpecRequest<Talent>(spec);
        var result = await mediator.Send(request, cancellationToken);
        return TypedResults.Ok(result);
    }
}