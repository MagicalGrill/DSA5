using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SonderfertigkeitBrauchtEigenschaft))]
public class SonderfertigkeitBrauchtEigenschaft : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey(nameof(Welt.Eigenschaft))]
    public Guid EigenschaftId { get; set; }
    
    public Eigenschaft Eigenschaft { get; set; } = null!;
    public int Wert { get; set; }
}