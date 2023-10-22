using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Queries;
using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Handlers;

public sealed class BaseGetByIdHandler<T> : IRequestHandler<BaseGetByIdRequest<T>, T?> where T : BaseEntity
{
    private readonly IRepository<T> _repository;

    public BaseGetByIdHandler(IRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task<T?> Handle(BaseGetByIdRequest<T> request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id, cancellationToken);
    }
}