using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Rassen.Queries;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Rassen.Handlers;

public sealed class GetSpeziesByIdHandler : IRequestHandler<GetSpeziesByIdRequest, Spezies?>
{
    private readonly IRepository<Spezies> _repository;

    public GetSpeziesByIdHandler(IRepository<Spezies> repository)
    {
        _repository = repository;
    }

    public async Task<Spezies?> Handle(GetSpeziesByIdRequest request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id, cancellationToken);
    }
}