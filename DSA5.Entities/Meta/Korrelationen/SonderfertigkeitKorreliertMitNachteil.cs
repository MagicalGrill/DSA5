using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta.Korrelationen;

[Table("SonderfertigkeitKorreliertMitNachteil")]
public class SonderfertigkeitKorreliertMitNachteil : BaseEntity
{
    [ForeignKey("Sonderfertigkeit")]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey("Nachteil")]
    public Guid NachteilId { get; set; }
    public Korrelation Korrelation { get; set; }
}