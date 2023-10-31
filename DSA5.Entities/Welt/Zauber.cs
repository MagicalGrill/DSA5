using DSA5.Entities.Meta.Korrelationen;

namespace DSA5.Entities.Welt;

public class Zauber : Fertigkeit
{
    public bool ModifiziertDurchSeelenkraft { get; set; }
    public bool ModifiziertDurchZaehigkeit { get; set; }

    public virtual IEnumerable<ZauberVerbreitung> Verbreitung { get; set; } = null!;
}