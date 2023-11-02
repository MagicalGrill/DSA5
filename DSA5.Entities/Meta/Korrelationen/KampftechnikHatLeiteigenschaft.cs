using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(KampftechnikHatLeiteigenschaft))]
public sealed class KampftechnikHatLeiteigenschaft : BaseEntity
{
    [ForeignKey(nameof(Kampftechnik))] public Guid KampftechnikId { get; set; }
    [ForeignKey(nameof(Eigenschaft))] public Guid LeiteigenschaftId { get; set; }

    public Eigenschaft Leiteigenschaft { get; set; } = null!;
}