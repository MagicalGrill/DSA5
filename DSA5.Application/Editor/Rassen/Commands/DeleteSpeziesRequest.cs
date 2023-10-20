using MediatR;

namespace DSA5.Application.Editor.Rassen.Commands;

public sealed record DeleteSpeziesRequest(Guid Id) : IRequest;