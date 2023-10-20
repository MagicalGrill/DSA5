using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table(nameof(SonderfertigkeitBedingtNachteil))]
public class SonderfertigkeitBedingtNachteil : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    
    [ForeignKey(nameof(Welt.Nachteil))]
    public Guid NachteilId { get; set; }
    public Nachteil Nachteil { get; set; } = null!;
}