using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(NachteilEmpfiehltNachteil))]
public sealed class NachteilEmpfiehltNachteil : BaseEntity
{
    [ForeignKey(nameof(Nachteil))]
    public Guid NachteilId { get; set; }
    [ForeignKey(nameof(Nachteil))]
    public Guid EmpfehlungId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }

    public Nachteil Empfehlung { get; set; } = null!;
}