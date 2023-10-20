using MediatR;

namespace DSA5.Application.Editor.Eigenschaften.Commands;

public sealed record DeleteEigenschaftRequest(Guid Id) : IRequest;