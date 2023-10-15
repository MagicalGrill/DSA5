using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Entities.Welt;

public class SonderfertigkeitUpgrade : Sonderfertigkeit
{
    [ForeignKey(nameof(Sonderfertigkeit))]
    public Guid VorgaengerId { get; set; }
    public Sonderfertigkeit Vorgaenger { get; set; } = null!;
}