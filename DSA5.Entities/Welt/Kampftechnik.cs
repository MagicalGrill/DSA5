using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Meta;
using DSA5.Entities.Meta.Korrelationen;

namespace DSA5.Entities.Welt;

[Table(nameof(Kampftechnik))]
public class Kampftechnik : DescriptedEntity
{
    public Kampfart Kampfart { get; set; }

    [ForeignKey(nameof(Meta.Steigerungsfaktor))]
    public Guid SteigerungsfaktorId { get; set; }

    public Steigerungsfaktor Steigerungsfaktor { get; set; } = null!;
    public virtual IEnumerable<KampftechnikHatLeiteigenschaft> Leiteigenschaften { get; set; } = null!;
}