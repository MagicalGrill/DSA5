using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Commands;

public sealed record BaseDeleteRequest<T>(Guid Id) : IRequest where T : BaseEntity;