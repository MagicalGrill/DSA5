using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta.Korrelationen;

[Table("SonderfertigkeitKorreliertMitNachteil")]
public class SonderfertigkeitKorreliertMitNachteil : BaseEntity
{
    [ForeignKey("Sonderfertigkeit")]
    public int SonderfertigkeitId { get; set; }
    [ForeignKey("Nachteil")]
    public int NachteilId { get; set; }
    public Korrelation Korrelation { get; set; }
}