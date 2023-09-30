using System.ComponentModel.DataAnnotations.Schema;

namespace DSA5.Entities.Meta.Korrelationen;

[Table("SpeziesKorreliertMitKultur")]
public class SpeziesKorreliertMitKultur
{
    [ForeignKey("Spezies")]
    public int SpeziesId { get; set; }
    [ForeignKey("Kultur")]
    public int KulturId { get; set; }
    
    public Korrelation Korrelation { get; set; }
}