using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Application.Editor.Base.Handlers;
using DSA5.Application.Editor.Geweihtentraditionen.Specs;
using DSA5.Entities.Welt;

namespace DSA5.Application.Editor.Geweihtentraditionen.Handlers;

public sealed class UpdateGeweihtentraditionHandler : BaseUpdateHandler<Geweihtentradition>
{
    public UpdateGeweihtentraditionHandler(IRepository<Geweihtentradition> repository) : base(repository)
    {
    }

    public override async Task Handle(BaseUpdateRequest<Geweihtentradition> request,
        CancellationToken cancellationToken)
    {
        var tradition =
            await Repository.FirstOrDefaultAsync(new FullGeweihtentraditionGetByIdSpec(request.Id), cancellationToken);
        if (tradition is null) return;
        var item = request.Item;
        foreach (var aspekt in item.ErmoeglichteAspekte) aspekt.GeweihtentraditionId = tradition.Id;

        tradition.Name = item.Name;
        tradition.ErmoeglichteAspekte = item.ErmoeglichteAspekte;
        tradition.Beschreibung = item.Beschreibung?.Replace(Environment.NewLine, " ");
        tradition.LeiteigenschaftId = item.LeiteigenschaftId;
        tradition.ApKosten = item.ApKosten;
        tradition.LastUpdated = DateTime.UtcNow;
        await Repository.UpdateAsync(tradition, cancellationToken);
    }
}