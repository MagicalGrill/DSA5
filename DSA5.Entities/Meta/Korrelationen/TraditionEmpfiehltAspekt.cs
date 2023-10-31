using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(TraditionEmpfiehltAspekt))]
public sealed class TraditionEmpfiehltAspekt : BaseEntity
{
    [ForeignKey(nameof(Welt.Aspekt))] public Guid AspektId { get; set; }
    [ForeignKey(nameof(Tradition))] public Guid GeweihtentraditionId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }

    public Aspekt Aspekt { get; set; } = null!;
}