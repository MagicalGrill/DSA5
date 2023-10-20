using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Eigenschaften.Queries;

public sealed record GetEigenschaftByIdRequest(Guid Id) : IRequest<Eigenschaft?>;