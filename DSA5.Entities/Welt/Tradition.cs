using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table("Tradition")]
public class Tradition : DescriptedEntity
{
    [ForeignKey("Eigenschaft")]
    public int LeiteigenschaftId { get; set; }
    public Eigenschaft Leiteigenschaft { get; set; } = null!;
}