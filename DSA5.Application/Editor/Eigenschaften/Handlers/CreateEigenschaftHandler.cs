using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Eigenschaften.Commands;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Eigenschaften.Handlers;

public sealed class CreateEigenschaftHandler : IRequestHandler<CreateEigenschaftRequest, Eigenschaft>
{
    private readonly IRepository<Eigenschaft> _repository;

    public CreateEigenschaftHandler(IRepository<Eigenschaft> repository)
    {
        _repository = repository;
    }

    public async Task<Eigenschaft> Handle(CreateEigenschaftRequest request, CancellationToken cancellationToken)
    {
        return await _repository.AddAsync(request.Eigenschaft, cancellationToken);
    }
}