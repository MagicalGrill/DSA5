using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt.Voraussetzungen;

[Table("SonderfertigkeitBrauchtVorteil")]
public class SonderfertigkeitBrauchtVorteil : BaseEntity
{
    [ForeignKey("Sonderfertigkeit")]
    public int SonderfertigkeitId { get; set; }
    [ForeignKey("Vorteil")]
    public int VorteilId { get; set; }
}