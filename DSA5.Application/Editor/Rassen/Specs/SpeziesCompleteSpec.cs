using Ardalis.Specification;
using DSA5.Entities.Welt;

namespace DSA5.Application.Editor.Rassen.Specs;

public sealed class SpeziesCompleteSpec : Specification<Spezies>
{
    public SpeziesCompleteSpec()
    {
        Query.Include(spezies => spezies.EigenschaftModifikatoren)
            .ThenInclude(e => e.BedingteEigenschaftMoeglichkeiten);
    }
}