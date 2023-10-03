using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table("SpeziesBedingtVorteil")]
public class SpeziesBedingtVorteil : BaseEntity, IVorteilModifikator
{
    [ForeignKey("Spezies")]
    public Guid SpeziesId { get; set; }
    [ForeignKey("Vorteil")]
    public Guid VorteilId { get; set; }
    public Vorteil Vorteil { get; set; } = null!;
    public int Stufe { get; set; }

    public Eigenschaft? Eigenschaft { get; set; } = null;
    
    [ForeignKey("Talent")]
    public Guid? TalentId { get; set; }
    public Talent? Talent { get; set; }
}