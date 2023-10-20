using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Rassen.Commands;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Rassen.Handlers;

public sealed class CreateSpeziesHandler : IRequestHandler<CreateSpeziesRequest, Spezies>
{
    private readonly IRepository<Spezies> _repository;

    public CreateSpeziesHandler(IRepository<Spezies> repository)
    {
        _repository = repository;
    }

    public async Task<Spezies> Handle(CreateSpeziesRequest request, CancellationToken cancellationToken)
    {
        await _repository.AddAsync(request.Spezies, cancellationToken);
        return request.Spezies;
    }
}