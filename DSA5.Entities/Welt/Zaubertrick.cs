using System.ComponentModel.DataAnnotations.Schema;

namespace DSA5.Entities.Welt;

[Table(nameof(Zaubertrick))]
public class Zaubertrick : Sonderfertigkeit
{
    [ForeignKey(nameof(Merkmal))]
    public Guid MerkmalId { get; set; }
}