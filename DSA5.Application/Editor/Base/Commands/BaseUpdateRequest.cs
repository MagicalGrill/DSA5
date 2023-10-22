using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Commands;

public sealed record BaseUpdateRequest<T>(Guid Id, T Item) : IRequest where T : BaseEntity;