using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Handlers;

public class BaseUpdateHandler<T> : IRequestHandler<BaseUpdateRequest<T>> where T : BaseEntity
{
    protected readonly IRepository<T> Repository;

    public BaseUpdateHandler(IRepository<T> repository)
    {
        Repository = repository;
    }

    public virtual async Task Handle(BaseUpdateRequest<T> request, CancellationToken cancellationToken)
    {
        request.Item.LastUpdated = DateTime.UtcNow;
        request.Item.Id = request.Id;
        await Repository.UpdateAsync(request.Item, cancellationToken);
    }
}