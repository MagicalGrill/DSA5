using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta.Korrelationen;

[Table("SpeziesKorreliertMitNachteil")]
public class SpeziesKorreliertMitNachteil : BaseEntity
{
    [ForeignKey("Spezies")]
    public int SpeziesId { get; set; }
    [ForeignKey("Vorteil")]
    public int VorteilId { get; set; }
    public Korrelation Korrelation { get; set; }
}