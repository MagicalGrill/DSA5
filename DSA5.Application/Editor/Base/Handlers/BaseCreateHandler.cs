using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Handlers;

public sealed class BaseCreateHandler<T> : IRequestHandler<BaseCreateRequest<T>, T> where T : BaseEntity
{
    private readonly IRepository<T> _repository;

    public BaseCreateHandler(IRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task<T> Handle(BaseCreateRequest<T> request, CancellationToken cancellationToken)
    {
        request.Item.Created = DateTime.UtcNow;
        request.Item.LastUpdated = DateTime.UtcNow;
        return await _repository.AddAsync(request.Item, cancellationToken);
    }
}