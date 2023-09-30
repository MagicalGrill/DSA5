using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table("Vorteil")]
public class Vorteil : BaseEntity
{
    public string Name { get; set; } = null!;
    public int MaxStufe { get; set; }
    public int ApProStufe { get; set; }

    [ForeignKey("Eigenschaft")]
    public int? EigenschaftId { get; set; }
    public Eigenschaft? Eigenschaft { get; set; }
    
    [ForeignKey("Talent")]
    public int? TalentId { get; set; }
    public Talent? Talent { get; set; }
}