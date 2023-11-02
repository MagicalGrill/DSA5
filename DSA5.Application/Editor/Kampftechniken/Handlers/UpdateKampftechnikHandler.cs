using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Application.Editor.Kampftechniken.Specs;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Kampftechniken.Handlers;

public sealed class UpdateKampftechnikHandler : IRequestHandler<BaseUpdateRequest<Kampftechnik>>
{
    private readonly IRepository<Kampftechnik> _repository;

    public UpdateKampftechnikHandler(IRepository<Kampftechnik> repository)
    {
        _repository = repository;
    }

    public async Task Handle(BaseUpdateRequest<Kampftechnik> request, CancellationToken cancellationToken)
    {
        var kampftechnik =
            await _repository.FirstOrDefaultAsync(new KampftechnikByIdCompleteSpec(request.Id),
                cancellationToken);
        if (kampftechnik is null) return;
        var item = request.Item;
        foreach (var leiteigenschaft in item.Leiteigenschaften) leiteigenschaft.KampftechnikId = kampftechnik.Id;

        kampftechnik.Name = item.Name;
        kampftechnik.Leiteigenschaften = item.Leiteigenschaften;
        kampftechnik.Beschreibung = item.Beschreibung;
        kampftechnik.SteigerungsfaktorId = item.SteigerungsfaktorId;
        kampftechnik.Kampfart = item.Kampfart;
        kampftechnik.LastUpdated = DateTime.UtcNow;
        await _repository.UpdateAsync(kampftechnik, cancellationToken);
    }
}