using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta.Korrelationen;

namespace DSA5.Entities.Welt;

[Table(nameof(Sonderfertigkeit))]
public class Sonderfertigkeit : DescriptedEntity
{
    public int ApKosten { get; set; }

    public virtual IEnumerable<SonderfertigkeitBrauchtTalent> TalentVoraussetzungen { get; set; } = null!;
    public virtual IEnumerable<SonderfertigkeitBrauchtSonderfertigkeit> SonderfertigkeitVoraussetzungen { get; set; } = null!;
    public virtual IEnumerable<SonderfertigkeitBrauchtEigenschaft> EigenschaftVoraussetzungen { get; set; } = null!;
    public virtual IEnumerable<SonderfertigkeitBrauchtVorteil> VorteilVoraussetzungen { get; set; } = null!;
}