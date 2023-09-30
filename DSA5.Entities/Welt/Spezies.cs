using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta.Korrelationen;
using DSA5.Entities.Welt.Modifikatoren;

namespace DSA5.Entities.Welt;

[Table("Spezies")]
public class Spezies : BaseEntity
{
    public string Name { get; set; } = null!;
    public int Lebenspunkte { get; set; }
    public int Seelenkraft { get; set; }
    public int Zaehigkeit { get; set; }
    public int Geschwindigkeit { get; set; }
    public int ApKosten { get; set; }

    public virtual IEnumerable<SpeziesBedingtEigenschaft> EigenschaftModifikatoren { get; set; } = null!;
    public virtual IEnumerable<SpeziesBedingtVorteil> VorteilModifikatoren { get; set; } = null!;
    public virtual IEnumerable<SpeziesKorreliertMitKultur> KulturKorrelationen { get; set; } = null!;
}