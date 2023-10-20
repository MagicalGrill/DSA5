using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta.Korrelationen;
using DSA5.Entities.Welt.Modifikatoren;

namespace DSA5.Entities.Welt;

[Table(nameof(Spezies))]
public class Spezies : DescriptedEntity
{
    public int Lebenspunkte { get; set; }
    public int Seelenkraft { get; set; }
    public int Zaehigkeit { get; set; }
    public int Geschwindigkeit { get; set; }
    public int ApKosten { get; set; }

    public virtual IEnumerable<SpeziesBedingtEigenschaften> EigenschaftModifikatoren { get; set; } = null!;
    
    public virtual IEnumerable<SpeziesEmpfiehltKultur> EmpfohleneKulturen { get; set; } = null!;
    public virtual IEnumerable<SpeziesEmpfiehltVorteil> EmpfohleneVorteile { get; set; } = null!;
    public virtual IEnumerable<SpeziesEmpfiehltNachteil> EmpfohleneNachteile { get; set; } = null!;

}