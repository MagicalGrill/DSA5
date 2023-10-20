using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Eigenschaften.Commands;

public sealed record UpdateEigenschaftRequest(Guid Id, Eigenschaft Eigenschaft) : IRequest;