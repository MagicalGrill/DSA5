using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Meta.Korrelationen;

[Table("SpeziesKorreliertMitKultur")]
public class SpeziesKorreliertMitKultur : BaseEntity
{
    [ForeignKey("Spezies")]
    public int SpeziesId { get; set; }
    [ForeignKey("Kultur")]
    public int KulturId { get; set; }
    
    public Korrelation Korrelation { get; set; }
}