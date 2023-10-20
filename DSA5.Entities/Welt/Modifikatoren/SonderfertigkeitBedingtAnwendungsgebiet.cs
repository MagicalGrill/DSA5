using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table(nameof(SonderfertigkeitBedingtAnwendungsgebiet))]
public class SonderfertigkeitBedingtAnwendungsgebiet : BaseEntity
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey(nameof(Welt.Anwendungsgebiet))]
    public Guid AnwendungsgebietId { get; set; }
    public Anwendungsgebiet Anwendungsgebiet { get; set; } = null!;
}