using Ardalis.Specification;
using DSA5.Entities.Welt;

namespace DSA5.Application.Editor.Geweihtentraditionen.Specs;

public sealed class GeweihtentraditionByIdCompleteSpec : Specification<Geweihtentradition>
{
    public GeweihtentraditionByIdCompleteSpec(Guid id)
    {
        Query
            .Where(t => t.Id == id)
            .Include(t => t.ErmoeglichteAspekte)
            .ThenInclude(a => a.Aspekt)
            .Include(t => t.Leiteigenschaft);
    }
}