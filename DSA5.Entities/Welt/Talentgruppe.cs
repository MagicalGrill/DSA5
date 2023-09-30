using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

[Table("Talentgruppe")]
public sealed class Talentgruppe : BaseEntity
{
    public string Name { get; set; } = null!;
    
    public Eigenschaft Wurf1 { get; set; }
    public Eigenschaft Wurf2 { get; set; }
    public Eigenschaft Wurf3 { get; set; }
}