using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table(nameof(Talentgruppe))]
public sealed class Talentgruppe : DescriptedEntity
{
    [ForeignKey(nameof(Eigenschaft))]
    public Guid Wurf1Id { get; set; }
    public Eigenschaft Wurf1 { get; set; } = null!;
    
    [ForeignKey(nameof(Eigenschaft))]
    public Guid Wurf2Id { get; set; }
    public Eigenschaft Wurf2 { get; set; } = null!;
    
    [ForeignKey(nameof(Eigenschaft))]
    public Guid Wurf3Id { get; set; }
    public Eigenschaft Wurf3 { get; set; } = null!;
}