using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Voraussetzungen;

[Table("SonderfertigkeitBrauchtTalent")]
public class SonderfertigkeitBrauchtTalent : BaseEntity
{
    [ForeignKey("Sonderfertigkeit")]
    public int SonderfertigkeitId { get; set; }
    [ForeignKey("Talent")]
    public int TalentId { get; set; }
    public Talent Talent { get; set; } = null!;
    public int Wert { get; set; }
}