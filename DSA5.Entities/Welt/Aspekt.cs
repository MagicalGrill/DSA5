using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table(nameof(Aspekt))]
public class Aspekt : DescriptedEntity
{
    [ForeignKey(nameof(Tradition))] public Guid? GeweihtentraditionId { get; set; }
    public Geweihtentradition? Geweihtentradition { get; set; }
}