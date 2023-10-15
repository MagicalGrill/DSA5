using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SpeziesEmpfiehltKultur))]
public sealed class SpeziesEmpfiehltKultur : BaseEntity
{
    [ForeignKey(nameof(Spezies))]
    public Guid SpeziesId { get; set; }
    [ForeignKey(nameof(Welt.Kultur))]
    public Guid KulturId { get; set; }
    public Empfehlungsstufe Empfehlungsstufe { get; set; }

    public Kultur Kultur { get; set; } = null!;
}