using System.ComponentModel.DataAnnotations.Schema;

namespace DSA5.Entities.Welt.Voraussetzungen;

[Table("SonderfertigkeitBrauchtSonderfertigkeit")]
public class SonderfertigkeitBrauchtSonderfertigkeit
{
    [ForeignKey("Sonderfertigkeit")]
    public int SonderfertigkeitId { get; set; }
    [ForeignKey("Sonderfertigkeit")]
    public int VoraussetzungId { get; set; }
}