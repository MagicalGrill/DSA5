using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Eigenschaften.Commands;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Eigenschaften.Handlers;

public sealed class DeleteEigenschaftHandler : IRequestHandler<DeleteEigenschaftRequest>
{
    private readonly IRepository<Eigenschaft> _repository;

    public DeleteEigenschaftHandler(IRepository<Eigenschaft> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteEigenschaftRequest request, CancellationToken cancellationToken)
    {
        var eigenschaft = await _repository.GetByIdAsync(request.Id, cancellationToken);
        if (eigenschaft is null) return;
        await _repository.DeleteAsync(eigenschaft, cancellationToken);
    }
}