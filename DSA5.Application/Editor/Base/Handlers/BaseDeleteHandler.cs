using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Handlers;

public sealed class BaseDeleteHandler<T> : IRequestHandler<BaseDeleteRequest<T>> where T : BaseEntity
{
    private readonly IRepository<T> _repository;

    public BaseDeleteHandler(IRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task Handle(BaseDeleteRequest<T> request, CancellationToken cancellationToken)
    {
        var t = await _repository.GetByIdAsync(request.Id, cancellationToken);
        if (t is null) return;
        await _repository.DeleteAsync(t, cancellationToken);
    }
}