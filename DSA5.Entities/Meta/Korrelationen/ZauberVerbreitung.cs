using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta.Korrelationen;

[Table("ZauberVerbreitung")]
public class ZauberVerbreitung : BaseEntity
{
    [ForeignKey("Zauber")]
    public Guid ZauberId { get; set; }
    [ForeignKey("Tradition")]
    public Guid TraditionId { get; set; }
}