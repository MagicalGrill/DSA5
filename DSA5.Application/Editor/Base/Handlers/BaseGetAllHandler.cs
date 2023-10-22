using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Queries;
using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Handlers;

public sealed class BaseGetAllHandler<T> : IRequestHandler<BaseGetAllRequest<T>, ICollection<T>> where T : BaseEntity
{
    private readonly IRepository<T> _repository;

    public BaseGetAllHandler(IRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task<ICollection<T>> Handle(BaseGetAllRequest<T> request, CancellationToken cancellationToken)
    {
        return await _repository.ListAsync(cancellationToken);
    }
}