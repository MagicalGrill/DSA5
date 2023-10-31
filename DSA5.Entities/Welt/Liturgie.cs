using DSA5.Entities.Meta.Korrelationen;

namespace DSA5.Entities.Welt;

public class Liturgie : Fertigkeit
{
    public virtual IEnumerable<LiturgieVerbreitung> Verbreitung { get; set; } = null!;
}