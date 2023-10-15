using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SonderfertigkeitBrauchtSonderfertigkeit))]
public class SonderfertigkeitBrauchtSonderfertigkeit : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid VoraussetzungId { get; set; }

    public Sonderfertigkeit Voraussetzung { get; set; } = null!;
}