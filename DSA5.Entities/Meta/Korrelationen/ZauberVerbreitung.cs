using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(ZauberVerbreitung))]
public sealed class ZauberVerbreitung : BaseEntity
{
    [ForeignKey(nameof(Zauber))]
    public Guid ZauberId { get; set; }
    [ForeignKey(nameof(Tradition))]
    public Guid TraditionId { get; set; }
}