using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SonderfertigkeitBrauchtMerkmal))]
public sealed class SonderfertigkeitBrauchtMerkmal : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    public int GesamtStufe { get; set; }
    public int StufeProZauber { get; set; }
    public int AnzahlZauber { get; set; }
}