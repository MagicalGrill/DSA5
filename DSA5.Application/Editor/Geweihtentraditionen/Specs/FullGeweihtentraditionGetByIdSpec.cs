using Ardalis.Specification;
using DSA5.Entities.Welt;

namespace DSA5.Application.Editor.Geweihtentraditionen.Specs;

public sealed class FullGeweihtentraditionGetByIdSpec : Specification<Geweihtentradition>
{
    public FullGeweihtentraditionGetByIdSpec(Guid id)
    {
        Query
            .Include(t => t.ErmoeglichteAspekte)
            .ThenInclude(a => a.Aspekt)
            .Include(t => t.Leiteigenschaft)
            .Where(t => t.Id == id);
    }
}