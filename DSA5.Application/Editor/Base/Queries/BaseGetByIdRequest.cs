using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Queries;

public sealed record BaseGetByIdRequest<T>(Guid Id) : IRequest<T?> where T : BaseEntity;