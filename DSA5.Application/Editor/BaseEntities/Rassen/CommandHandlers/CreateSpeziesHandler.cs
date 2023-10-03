using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.BaseEntities.Rassen.Commands;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.BaseEntities.Rassen.CommandHandlers;

public sealed class CreateSpeziesHandler : IRequestHandler<CreateSpezies, Spezies>
{
    private readonly IRepository<Spezies> _repository;

    public CreateSpeziesHandler(IRepository<Spezies> repository)
    {
        _repository = repository;
    }
    
    public async Task<Spezies> Handle(CreateSpezies request, CancellationToken cancellationToken)
    {
        var spezies = new Spezies()
        {
            ApKosten = request.ApKosten,
            Beschreibung = request.Beschreibung,
            Geschwindigkeit = request.Geschwindigkeit,
            Lebenspunkte = request.Lebenspunkte,
            Name = request.Name,
            Seelenkraft = request.Seelenkraft,
            Zaehigkeit = request.Zaehigkeit
        };

        await _repository.AddAsync(spezies, cancellationToken);
        return spezies;
    }
}