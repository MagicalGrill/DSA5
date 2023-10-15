using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(KulturEmpfiehltTalent))]
public sealed class KulturEmpfiehltTalent : BaseEntity
{
    [ForeignKey(nameof(Kultur))]
    public Guid KulturId { get; set; }
    [ForeignKey(nameof(Welt.Talent))]
    public Guid TalentId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }
    
    public Talent Talent { get; set; } = null!;
}