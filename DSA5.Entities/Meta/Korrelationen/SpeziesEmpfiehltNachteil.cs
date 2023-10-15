using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SpeziesEmpfiehltNachteil))]
public sealed class SpeziesEmpfiehltNachteil : BaseEntity
{
    [ForeignKey(nameof(Spezies))]
    public Guid SpeziesId { get; set; }
    [ForeignKey(nameof(Welt.Nachteil))]
    public Guid NachteilId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }
    
    public Nachteil Nachteil { get; set; } = null!;
}