using System.ComponentModel.DataAnnotations.Schema;

namespace DSA5.Entities.Welt;

[Table(nameof(Segnung))]
public class Segnung : Sonderfertigkeit
{
    public int KarmalKosten { get; set; }

    [ForeignKey(nameof(Welt.Aspekt))] public Guid AspektId { get; set; }

    public Aspekt Aspekt { get; set; }
}