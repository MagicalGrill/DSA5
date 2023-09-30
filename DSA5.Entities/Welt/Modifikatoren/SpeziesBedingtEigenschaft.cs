using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table("SpeziesBedingtEigenschaft")]
public class SpeziesBedingtEigenschaft : BaseEntity, IEigenschaftModifikator
{
    [ForeignKey("Spezies")]
    public int SpeziesId { get; set; }
    public Eigenschaft Eigenschaft { get; set; }
    public int Wert { get; set; }
}