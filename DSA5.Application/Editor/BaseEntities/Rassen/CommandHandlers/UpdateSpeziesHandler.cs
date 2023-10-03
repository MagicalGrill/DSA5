using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.BaseEntities.Rassen.Commands;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.BaseEntities.Rassen.CommandHandlers;

public sealed class UpdateSpeziesHandler : IRequestHandler<UpdateSpezies, Guid>
{
    private readonly IRepository<Spezies> _repository;

    public UpdateSpeziesHandler(IRepository<Spezies> repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(UpdateSpezies request, CancellationToken cancellationToken)
    {
        var spezies = request.UpdatedSpezies;
        await _repository.UpdateAsync(spezies, cancellationToken);
        return spezies.Id;
    }
}