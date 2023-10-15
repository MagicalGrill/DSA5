using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(NachteilBrauchtVorteil))]
public sealed class NachteilBrauchtVorteil : BaseEntity
{
    [ForeignKey(nameof(Welt.Nachteil))]
    public Guid NachteilId { get; set; }
    [ForeignKey(nameof(Vorteil))]
    public Guid VorteilId { get; set; }

    public Nachteil Nachteil { get; set; } = null!;
}