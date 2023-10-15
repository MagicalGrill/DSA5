using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SonderfertigkeitBrauchtSpezies))]
public class SonderfertigkeitBrauchtSpezies : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey(nameof(Spezies))]
    public Guid SpeziesId { get; set; }
}