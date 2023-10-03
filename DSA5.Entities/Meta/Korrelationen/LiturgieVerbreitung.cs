using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta.Korrelationen;

[Table("LiturgieVerbreitung")]
public class LiturgieVerbreitung : BaseEntity
{
    [ForeignKey("Liturgie")]
    public Guid ZauberId { get; set; }
    [ForeignKey("Tradition")]
    public Guid TraditionId { get; set; }
}