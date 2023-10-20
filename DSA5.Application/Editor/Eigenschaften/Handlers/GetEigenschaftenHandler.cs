using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Eigenschaften.Queries;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Eigenschaften.Handlers;

public sealed class GetEigenschaftenHandler : IRequestHandler<GetEigenschaftenRequest, ICollection<Eigenschaft>>
{
    private readonly IRepository<Eigenschaft> _repository;

    public GetEigenschaftenHandler(IRepository<Eigenschaft> repository)
    {
        _repository = repository;
    }

    public async Task<ICollection<Eigenschaft>> Handle(GetEigenschaftenRequest request,
        CancellationToken cancellationToken)
    {
        return await _repository.ListAsync(cancellationToken);
    }
}