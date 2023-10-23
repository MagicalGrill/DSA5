using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table(nameof(Tradition))]
public abstract class Tradition : DescriptedEntity
{
    public int ApKosten { get; set; }
    [ForeignKey(nameof(Tradition))] public Guid LeiteigenschaftId { get; set; }

    public Eigenschaft Leiteigenschaft { get; set; } = null!;
}