using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SonderfertigkeitEmpfiehltSonderfertigkeit))]
public sealed class SonderfertigkeitEmpfiehltSonderfertigkeit : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid EmpfehlungId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }
}