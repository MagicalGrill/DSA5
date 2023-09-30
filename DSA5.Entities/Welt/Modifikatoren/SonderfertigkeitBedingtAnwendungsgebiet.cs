using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table("SonderfertigkeitBedingtAnwendungsgebiet")]
public class SonderfertigkeitBedingtAnwendungsgebiet : BaseEntity
{
    [ForeignKey("Sonderfertigkeit")]
    public int SonderfertigkeitId { get; set; }
    [ForeignKey("Anwendungsgebiet")]
    public int AnwendungsgebietId { get; set; }
    public Anwendungsgebiet Anwendungsgebiet { get; set; } = null!;
}