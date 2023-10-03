using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.BaseEntities.Rassen.Commands;

public sealed class CreateSpezies : IRequest<Spezies>
{
    public int ApKosten { get; set; }
    public string? Beschreibung { get; set; }
    public int Geschwindigkeit { get; set; }
    public int Lebenspunkte { get; set; }
    public required string Name { get; set; }
    public int Seelenkraft { get; set; }
    public int Zaehigkeit { get; set; }

    public Guid UserId { get; set; }
}