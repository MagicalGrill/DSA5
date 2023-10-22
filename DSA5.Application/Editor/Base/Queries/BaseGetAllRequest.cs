using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Queries;

public sealed record BaseGetAllRequest<T> : IRequest<ICollection<T>> where T : BaseEntity;