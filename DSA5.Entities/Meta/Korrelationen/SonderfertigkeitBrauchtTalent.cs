using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SonderfertigkeitBrauchtTalent))]
public class SonderfertigkeitBrauchtTalent : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey(nameof(Talent))]
    public Guid TalentId { get; set; }
    public Talent Talent { get; set; } = null!;
    public int Wert { get; set; }
}