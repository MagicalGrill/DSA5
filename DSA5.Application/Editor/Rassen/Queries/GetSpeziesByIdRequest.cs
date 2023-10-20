using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Rassen.Queries;

public record GetSpeziesByIdRequest(Guid Id) : IRequest<Spezies?>;