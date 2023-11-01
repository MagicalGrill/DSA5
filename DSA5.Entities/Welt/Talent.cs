using System.ComponentModel.DataAnnotations.Schema;

namespace DSA5.Entities.Welt;

public class Talent : Fertigkeit
{
    [ForeignKey(nameof(Welt.Talentgruppe))]
    public Guid TalentgruppeId { get; set; }

    public Talentgruppe Talentgruppe { get; set; } = null!;
    public MeisterBoolean BeeinflusstDurchBelastung { get; set; }

    public virtual IEnumerable<Anwendungsgebiet> Anwendungsgebiete { get; set; } = null!;
}