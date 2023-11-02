using Ardalis.Specification;
using DSA5.Entities.Welt;

namespace DSA5.Application.Editor.Kampftechniken.Specs;

public sealed class KampftechnikCompleteSpec : Specification<Kampftechnik>
{
    public KampftechnikCompleteSpec()
    {
        Query
            .Include(k => k.Steigerungsfaktor)
            .Include(k => k.Leiteigenschaften)
            .ThenInclude(e => e.Leiteigenschaft);
    }
}