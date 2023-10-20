using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Eigenschaften.Commands;

public sealed record CreateEigenschaftRequest(Eigenschaft Eigenschaft) : IRequest<Eigenschaft>;