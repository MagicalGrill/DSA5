using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(ProfessionEmpfiehltSonderfertigkeit))]
public class ProfessionEmpfiehltSonderfertigkeit : BaseEntity
{
    [ForeignKey(nameof(Profession))]
    public Guid ProfessionId { get; set; }
    [ForeignKey(nameof(Welt.Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }

    public Sonderfertigkeit Sonderfertigkeit { get; set; } = null!;
}