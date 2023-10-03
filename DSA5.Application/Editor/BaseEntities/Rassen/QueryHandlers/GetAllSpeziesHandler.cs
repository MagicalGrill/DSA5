using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.BaseEntities.Rassen.Queries;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.BaseEntities.Rassen.QueryHandlers;

public class GetAllSpeziesHandler : IRequestHandler<GetAllSpezies, ICollection<Spezies>>
{
    private readonly IRepository<Spezies> _repository;

    public GetAllSpeziesHandler(IRepository<Spezies> repository)
    {
        _repository = repository;
    }

    public async Task<ICollection<Spezies>> Handle(GetAllSpezies request, CancellationToken cancellationToken)
    {
        return await _repository.ListAsync(cancellationToken);
    }
}