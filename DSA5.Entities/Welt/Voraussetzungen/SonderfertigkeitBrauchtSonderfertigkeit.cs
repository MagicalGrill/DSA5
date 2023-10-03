using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Voraussetzungen;

[Table("SonderfertigkeitBrauchtSonderfertigkeit")]
public class SonderfertigkeitBrauchtSonderfertigkeit : BaseEntity
{
    [ForeignKey("Sonderfertigkeit")]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey("Sonderfertigkeit")]
    public Guid VoraussetzungId { get; set; }
}