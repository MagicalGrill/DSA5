using Ardalis.Specification;
using DSA5.Entities.Welt;

namespace DSA5.Application.Editor.Kampftechniken.Specs;

public sealed class KampftechnikByIdCompleteSpec : Specification<Kampftechnik>
{
    public KampftechnikByIdCompleteSpec(Guid id)
    {
        Query.Where(k => k.Id == id)
            .Include(k => k.Steigerungsfaktor)
            .Include(k => k.Leiteigenschaften)
            .ThenInclude(e => e.Leiteigenschaft);
    }
}