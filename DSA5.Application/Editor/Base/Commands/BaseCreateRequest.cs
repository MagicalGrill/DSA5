using DSA5.Entities.Common.Contracts;
using MediatR;

namespace DSA5.Application.Editor.Base.Commands;

public sealed record BaseCreateRequest<T>(T Item) : IRequest<T> where T : BaseEntity;