using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.BaseEntities.Rassen.Commands;

public sealed class UpdateSpezies : IRequest<Guid>
{
    public Guid Id { get; set; }
    public Spezies UpdatedSpezies { get; set; } = null!;
    public Guid UserId { get; set; }
}