using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table("SonderfertigkeitBedingtNachteil")]
public class SonderfertigkeitBedingtNachteil : BaseEntity, INachteilModifikator
{
    [ForeignKey("Sonderfertigkeit")]
    public Guid SonderfertigkeitId { get; set; }
    
    [ForeignKey("Nachteil")]
    public Guid NachteilId { get; set; }
    public Nachteil Nachteil { get; set; } = null!;
    
    public int Stufe { get; set; }
    public Eigenschaft? Eigenschaft { get; set; }
    public Talent? Talent { get; set; }
}