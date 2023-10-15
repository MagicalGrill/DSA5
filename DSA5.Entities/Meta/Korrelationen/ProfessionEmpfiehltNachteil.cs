using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(ProfessionEmpfiehltNachteil))]
public class ProfessionEmpfiehltNachteil : BaseEntity
{
    [ForeignKey(nameof(Profession))]
    public Guid ProfessionId { get; set; }
    [ForeignKey(nameof(Welt.Nachteil))]
    public Guid NachteilId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }

    public Nachteil Nachteil { get; set; } = null!;
}