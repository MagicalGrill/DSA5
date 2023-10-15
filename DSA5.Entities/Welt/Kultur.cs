using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta.Korrelationen;
using DSA5.Entities.Welt.Modifikatoren;

namespace DSA5.Entities.Welt;

[Table(nameof(Kultur))]
public class Kultur : DescriptedEntity
{
    [ForeignKey(nameof(Kulturgruppe))]
    public Guid KulturgruppeId { get; set; }
    public int ApWert { get; set; }

    public virtual IEnumerable<KulturEmpfiehltVorteil> EmpfohleneVorteile { get; set; } = null!;
    public virtual IEnumerable<KulturEmpfiehltNachteil> EmpfohleneNachteile { get; set; } = null!;
    public virtual IEnumerable<KulturEmpfiehltTalent> EmpfohleneTalente { get; set; } = null!;
}