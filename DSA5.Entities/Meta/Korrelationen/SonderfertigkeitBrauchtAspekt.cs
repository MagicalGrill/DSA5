using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;
using DSA5.Entities.Welt;

namespace DSA5.Entities.Meta.Korrelationen;

[Table(nameof(SonderfertigkeitBrauchtAspekt))]
public sealed class SonderfertigkeitBrauchtAspekt : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    public int GesamtStufe { get; set; }
    public int StufeProLiturgie { get; set; }
    public int AnzahlLiturgien { get; set; }
}