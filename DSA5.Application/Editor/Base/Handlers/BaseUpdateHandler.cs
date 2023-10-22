using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Handlers;

public sealed class BaseUpdateHandler<T> : IRequestHandler<BaseUpdateRequest<T>> where T : BaseEntity
{
    private readonly IRepository<T> _repository;

    public BaseUpdateHandler(IRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task Handle(BaseUpdateRequest<T> request, CancellationToken cancellationToken)
    {
        request.Item.LastUpdated = DateTime.UtcNow;
        request.Item.Id = request.Id;
        await _repository.UpdateAsync(request.Item, cancellationToken);
    }
}