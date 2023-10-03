using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta;
using DSA5.Entities.Meta.Korrelationen;

namespace DSA5.Entities.Welt;

[Table("Liturgie")]
public class Liturgie : DescriptedEntity
{
    [ForeignKey("Steigerungsfaktor")]
    public int SteigerungsfaktorId { get; set; }
    public Steigerungsfaktor Steigerungsfaktor { get; set; } = null!;
    
    [ForeignKey("Eigenschaft")]
    public int Wurf1Id { get; set; }
    public Eigenschaft Wurf1 { get; set; } = null!;
    
    [ForeignKey("Eigenschaft")]
    public int Wurf2Id { get; set; }
    public Eigenschaft Wurf2 { get; set; } = null!;
    
    [ForeignKey("Eigenschaft")]
    public int Wurf3Id { get; set; }
    public Eigenschaft Wurf3 { get; set; } = null!;

    public virtual IEnumerable<LiturgieVerbreitung> Verbreitung { get; set; } = null!;
}