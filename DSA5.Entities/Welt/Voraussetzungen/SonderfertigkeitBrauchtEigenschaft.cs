using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Voraussetzungen;

[Table("SonderfertigkeitBrauchtEigenschaft")]
public class SonderfertigkeitBrauchtEigenschaft : BaseEntity
{
    [ForeignKey("Sonderfertigkeit")]
    public int SonderfertigkeitId { get; set; }
    public Eigenschaft Eigenschaft { get; set; }
    public int Wert { get; set; }
}