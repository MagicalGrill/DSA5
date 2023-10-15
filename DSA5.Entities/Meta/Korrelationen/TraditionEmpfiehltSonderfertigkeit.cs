using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(TraditionEmpfiehltSonderfertigkeit))]
public class TraditionEmpfiehltSonderfertigkeit : BaseEntity
{
    [ForeignKey(nameof(Tradition))]
    public Guid TraditionId { get; set; }
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }
}