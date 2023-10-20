using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Rassen.Commands;

public sealed record UpdateSpeziesRequest(Guid Id, Spezies Spezies) : IRequest;