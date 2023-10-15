using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(VorteilEmpfiehltNachteil))]
public class VorteilEmpfiehltNachteil : BaseEntity
{
    [ForeignKey(nameof(Welt.Vorteil))]
    public Guid VorteilId { get; set; }
    [ForeignKey(nameof(Nachteil))]
    public Guid NachteilId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }

    public Vorteil Vorteil { get; set; } = null!;
}