using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(KulturEmpfiehltVorteil))]
public sealed class KulturEmpfiehltVorteil : BaseEntity
{
    [ForeignKey(nameof(Kultur))]
    public Guid KulturId { get; set; }
    [ForeignKey(nameof(Welt.Vorteil))]
    public Guid VorteilId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }

    public Vorteil Vorteil { get; set; } = null!;
}