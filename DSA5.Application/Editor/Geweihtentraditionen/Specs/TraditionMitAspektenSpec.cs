using Ardalis.Specification;
using DSA5.Entities.Welt;

namespace DSA5.Application.Editor.Geweihtentraditionen.Specs;

public sealed class TraditionMitAspektenSpec : Specification<Geweihtentradition>
{
    public TraditionMitAspektenSpec()
    {
        Query.Include(t => t.ErmoeglichteAspekte).ThenInclude(a => a.Aspekt);
    }
}