using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Rassen.Queries;

public class GetSpeziesRequest : IRequest<ICollection<Spezies>>
{
}