using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table("Vorteil")]
public class Vorteil : DescriptedEntity
{
    public int MaxStufe { get; set; }
    public int ApProStufe { get; set; }

    [ForeignKey("Eigenschaft")]
    public Guid? EigenschaftId { get; set; }
    public Eigenschaft? Eigenschaft { get; set; }
    
    [ForeignKey("Talent")]
    public Guid? TalentId { get; set; }
    public Talent? Talent { get; set; }
}