using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta;

namespace DSA5.Entities.Welt;

[Table(nameof(Fertigkeit))]
public abstract class Fertigkeit : DescriptedEntity
{
    [ForeignKey(nameof(Meta.Steigerungsfaktor))]
    public Guid SteigerungsfaktorId { get; set; }

    public Steigerungsfaktor Steigerungsfaktor { get; set; } = null!;

    [ForeignKey(nameof(Eigenschaft))] public Guid Wurf1Id { get; set; }
    public Eigenschaft Wurf1 { get; set; } = null!;

    [ForeignKey(nameof(Eigenschaft))] public Guid Wurf2Id { get; set; }
    public Eigenschaft Wurf2 { get; set; } = null!;

    [ForeignKey(nameof(Eigenschaft))] public Guid Wurf3Id { get; set; }
    public Eigenschaft Wurf3 { get; set; } = null!;
}