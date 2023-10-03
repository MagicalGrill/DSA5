using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Voraussetzungen;

[Table("SonderfertigkeitBrauchtSonderfertigkeit")]
public class SonderfertigkeitBrauchtSonderfertigkeit : BaseEntity
{
    [ForeignKey("Sonderfertigkeit")]
    public int SonderfertigkeitId { get; set; }
    [ForeignKey("Sonderfertigkeit")]
    public int VoraussetzungId { get; set; }
}