using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Eigenschaften.Commands;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Eigenschaften.Handlers;

public sealed class UpdateEigenschaftHandler : IRequestHandler<UpdateEigenschaftRequest>
{
    private readonly IRepository<Eigenschaft> _repository;

    public UpdateEigenschaftHandler(IRepository<Eigenschaft> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateEigenschaftRequest request, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(request.Eigenschaft, cancellationToken);
    }
}