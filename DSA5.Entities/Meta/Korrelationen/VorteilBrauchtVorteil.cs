using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(VorteilBrauchtVorteil))]
public sealed class VorteilBrauchtVorteil : BaseEntity
{
    [ForeignKey(nameof(Vorteil))]
    public Guid ZielId { get; set; }
    [ForeignKey(nameof(Vorteil))]
    public Guid VoraussetzungId { get; set; }
    
    public Vorteil Ziel { get; set; } = null!;
}