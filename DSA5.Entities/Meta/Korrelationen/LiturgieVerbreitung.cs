using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta.Korrelationen;

[Table("LiturgieVerbreitung")]
public class LiturgieVerbreitung : BaseEntity
{
    [ForeignKey("Liturgie")]
    public int ZauberId { get; set; }
    [ForeignKey("Tradition")]
    public int TraditionId { get; set; }
}