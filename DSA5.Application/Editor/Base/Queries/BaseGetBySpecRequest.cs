using Ardalis.Specification;
using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Queries;

public sealed record BaseGetBySpecRequest<T>(ISpecification<T> Specification) : IRequest<ICollection<T>>
    where T : BaseEntity;