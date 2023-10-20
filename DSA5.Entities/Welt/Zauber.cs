using System.ComponentModel.DataAnnotations.Schema;
using DSA5.Entities.Meta.Korrelationen;

namespace DSA5.Entities.Welt;

[Table(nameof(Zauber))]
public class Zauber : Talent
{
    public bool ModifiziertDurchSeelenkraft { get; set; }
    public bool ModifiziertDurchZaehigkeit { get; set; }
    
    public virtual IEnumerable<ZauberVerbreitung> Verbreitung { get; set; } = null!;
}