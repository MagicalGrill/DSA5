using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table(nameof(SpeziesKannEigenschaftBedingen))]
public sealed class SpeziesKannEigenschaftBedingen : BaseEntity
{
    [ForeignKey(nameof(SpeziesBedingtEigenschaften))]
    public Guid BedingteEigenschaftenId { get; set; }
    
    [ForeignKey(nameof(Welt.Eigenschaft))]
    public Guid EigenschaftId { get; set; }
    public Eigenschaft Eigenschaft { get; set; } = null!;
    
    public int Wert { get; set; }
}