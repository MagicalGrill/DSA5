using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Modifikatoren;

[Table("SonderfertigkeitBedingtAnwendungsgebiet")]
public class SonderfertigkeitBedingtAnwendungsgebiet : BaseEntity
{
    [ForeignKey("Sonderfertigkeit")]
    public Guid SonderfertigkeitId { get; set; }
    [ForeignKey("Anwendungsgebiet")]
    public Guid AnwendungsgebietId { get; set; }
    public Anwendungsgebiet Anwendungsgebiet { get; set; } = null!;
}