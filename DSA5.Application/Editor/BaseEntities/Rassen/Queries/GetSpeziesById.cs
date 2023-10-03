using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.BaseEntities.Rassen.Queries;

public class GetSpeziesById : IRequest<Spezies>
{
    public Guid Id { get; set; }
}