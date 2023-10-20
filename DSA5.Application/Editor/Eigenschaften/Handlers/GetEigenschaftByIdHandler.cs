using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Eigenschaften.Queries;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Eigenschaften.Handlers;

public sealed class GetEigenschaftByIdHandler : IRequestHandler<GetEigenschaftByIdRequest, Eigenschaft?>
{
    private readonly IRepository<Eigenschaft> _repository;

    public GetEigenschaftByIdHandler(IRepository<Eigenschaft> repository)
    {
        _repository = repository;
    }

    public async Task<Eigenschaft?> Handle(GetEigenschaftByIdRequest request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id, cancellationToken);
    }
}