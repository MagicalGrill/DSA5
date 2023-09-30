using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table("Talent")]
public sealed class Talent : BaseEntity
{
    public string Name { get; set; } = null!;
    
    [ForeignKey("Talentgruppe")]
    public int TalentgruppeId { get; set; }
    public Talentgruppe Talentgruppe { get; set; } = null!;
    
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
    
    public MeisterBoolean BeeinflusstDurchBelastung { get; set; }
}