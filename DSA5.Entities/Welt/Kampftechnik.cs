using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta;

namespace DSA5.Entities.Welt;

[Table(nameof(Kampftechnik))]
public class Kampftechnik : DescriptedEntity
{
    [ForeignKey(nameof(Meta.Steigerungsfaktor))]
    public Guid SteigerungsfaktorId { get; set; }
    public Steigerungsfaktor Steigerungsfaktor { get; set; } = null!;
}