using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

public class SonderfertigkeitUpgrade : Sonderfertigkeit
{
    [ForeignKey("Sonderfertigkeit")]
    public int VorgaengerId { get; set; }
    public Sonderfertigkeit Vorgaenger { get; set; } = null!;
}