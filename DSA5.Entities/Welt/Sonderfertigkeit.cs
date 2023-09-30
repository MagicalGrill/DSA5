using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt.Voraussetzungen;

namespace DSA5.Entities.Welt;

[Table("Sonderfertigkeit")]
public class Sonderfertigkeit : BaseEntity
{
    public string Name { get; set; } = null!;
    public int ApKosten { get; set; }
    public string? Zusatzinformation { get; set; }

    [ForeignKey("Anwendungsgebiet")] public int? AnwendungsgebietId { get; set; } = null;
    public Anwendungsgebiet? Anwendungsgebiet { get; set; }

    public virtual IEnumerable<SonderfertigkeitBrauchtTalent> TalentVoraussetzungen { get; set; } = null!;
    public virtual IEnumerable<SonderfertigkeitBrauchtSonderfertigkeit> SonderfertigkeitVoraussetzungen { get; set; } = null!;
    public virtual IEnumerable<SonderfertigkeitBrauchtEigenschaft> EigenschaftVoraussetzungen { get; set; } = null!;
    public virtual IEnumerable<SonderfertigkeitBrauchtVorteil> VorteilVoraussetzungen { get; set; } = null!;
}