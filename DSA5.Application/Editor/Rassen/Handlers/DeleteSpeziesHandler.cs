using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Rassen.Commands;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Rassen.Handlers;

public sealed class DeleteSpeziesHandler : IRequestHandler<DeleteSpeziesRequest>
{
    private readonly IRepository<Spezies> _repository;

    public DeleteSpeziesHandler(IRepository<Spezies> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteSpeziesRequest request, CancellationToken cancellationToken)
    {
        var spezies = await _repository.GetByIdAsync(request.Id, cancellationToken);
        if (spezies is null) return;
        await _repository.DeleteAsync(spezies, cancellationToken);
    }
}