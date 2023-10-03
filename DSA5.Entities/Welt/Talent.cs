using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta;

namespace DSA5.Entities.Welt;

[Table("Talent")]
public sealed class Talent : DescriptedEntity
{
    [ForeignKey("Talentgruppe")]
    public Guid TalentgruppeId { get; set; }
    public Talentgruppe Talentgruppe { get; set; } = null!;
    
    [ForeignKey("Steigerungsfaktor")]
    public Guid SteigerungsfaktorId { get; set; }
    public Steigerungsfaktor Steigerungsfaktor { get; set; } = null!;
    
    [ForeignKey("Eigenschaft")]
    public Guid Wurf1Id { get; set; }
    public Eigenschaft Wurf1 { get; set; } = null!;
    
    [ForeignKey("Eigenschaft")]
    public Guid Wurf2Id { get; set; }
    public Eigenschaft Wurf2 { get; set; } = null!;
    
    [ForeignKey("Eigenschaft")]
    public Guid Wurf3Id { get; set; }
    public Eigenschaft Wurf3 { get; set; } = null!;
    
    public MeisterBoolean BeeinflusstDurchBelastung { get; set; }
}