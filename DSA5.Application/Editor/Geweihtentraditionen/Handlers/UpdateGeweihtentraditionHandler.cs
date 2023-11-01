using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Application.Editor.Geweihtentraditionen.Specs;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Geweihtentraditionen.Handlers;

public sealed class UpdateGeweihtentraditionHandler : IRequestHandler<BaseUpdateRequest<Geweihtentradition>>
{
    private readonly IRepository<Geweihtentradition> _repository;

    public UpdateGeweihtentraditionHandler(IRepository<Geweihtentradition> repository)
    {
        _repository = repository;
    }

    public async Task Handle(BaseUpdateRequest<Geweihtentradition> request,
        CancellationToken cancellationToken)
    {
        var tradition =
            await _repository.FirstOrDefaultAsync(new GeweihtentraditionByIdCompleteSpec(request.Id),
                cancellationToken);
        if (tradition is null) return;
        var item = request.Item;
        foreach (var aspekt in item.ErmoeglichteAspekte) aspekt.GeweihtentraditionId = tradition.Id;

        tradition.Name = item.Name;
        tradition.ErmoeglichteAspekte = item.ErmoeglichteAspekte;
        tradition.Beschreibung = item.Beschreibung?
            .Replace(Environment.NewLine, " ")
            .Replace("\n", " ")
            .Replace("\r", " ");
        tradition.LeiteigenschaftId = item.LeiteigenschaftId;
        tradition.ApKosten = item.ApKosten;
        tradition.LastUpdated = DateTime.UtcNow;
        await _repository.UpdateAsync(tradition, cancellationToken);
    }
}