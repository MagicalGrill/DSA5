using Ardalis.Specification;
using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Rassen.Queries;
using DSA5.Application.Editor.Rassen.Specs;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Rassen.Handlers;

public sealed class GetSpeziesHandler : IRequestHandler<GetSpeziesRequest, ICollection<Spezies>>
{
    private readonly IRepository<Spezies> _repository;
    private readonly ISpecification<Spezies> _completeSpec;

    public GetSpeziesHandler(IRepository<Spezies> repository)
    {
        _repository = repository;
        _completeSpec = new SpeziesCompleteSpec();
    }

    public async Task<ICollection<Spezies>> Handle(GetSpeziesRequest request, CancellationToken cancellationToken)
    {
        return await _repository.ListAsync(_completeSpec, cancellationToken);
    }
}