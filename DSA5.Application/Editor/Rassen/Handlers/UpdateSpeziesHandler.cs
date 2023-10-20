using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Rassen.Commands;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Rassen.Handlers;

public sealed class UpdateSpeziesHandler : IRequestHandler<UpdateSpeziesRequest>
{
    private readonly IRepository<Spezies> _repository;

    public UpdateSpeziesHandler(IRepository<Spezies> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateSpeziesRequest request, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(request.Spezies, cancellationToken);
    }
}