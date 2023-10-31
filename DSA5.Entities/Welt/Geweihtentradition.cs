using DSA5.Entities.Meta.Korrelationen;

namespace DSA5.Entities.Welt;

public class Geweihtentradition : Tradition
{
    public virtual IEnumerable<TraditionEmpfiehltAspekt> ErmoeglichteAspekte { get; set; } = null!;
}