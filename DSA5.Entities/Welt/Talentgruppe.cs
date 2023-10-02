using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table("Talentgruppe")]
public sealed class Talentgruppe : DescriptedEntity
{
    [ForeignKey("Eigenschaft")]
    public int Wurf1Id { get; set; }
    public Eigenschaft Wurf1 { get; set; } = null!;
    
    [ForeignKey("Eigenschaft")]
    public int Wurf2Id { get; set; }
    public Eigenschaft Wurf2 { get; set; } = null!;
    
    [ForeignKey("Eigenschaft")]
    public int Wurf3Id { get; set; }
    public Eigenschaft Wurf3 { get; set; } = null!;
}