using System.ComponentModel.DataAnnotations.Schema;

namespace DSA5.Entities.Welt;

[Table(nameof(Stabzauber))]
public class Stabzauber : Sonderfertigkeit
{
    public int Volumen { get; set; }
    [ForeignKey(nameof(Merkmal))]
    public Guid MerkmalId { get; set; }
}