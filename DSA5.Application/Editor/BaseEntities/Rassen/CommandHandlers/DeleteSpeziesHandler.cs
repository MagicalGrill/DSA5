using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.BaseEntities.Rassen.Commands;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.BaseEntities.Rassen.CommandHandlers;

public sealed class DeleteSpeziesHandler : IRequestHandler<DeleteSpezies>
{
    private readonly IRepository<Spezies> _repository;

    public DeleteSpeziesHandler(IRepository<Spezies> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteSpezies request, CancellationToken cancellationToken)
    {
        var spezies = await _repository.GetByIdAsync(request.Id, cancellationToken);
        await _repository.DeleteAsync(spezies, cancellationToken);
    }
}