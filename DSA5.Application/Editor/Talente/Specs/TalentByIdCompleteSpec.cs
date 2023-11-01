using Ardalis.Specification;
using DSA5.Entities.Welt;

namespace DSA5.Application.Editor.Talente.Specs;

public sealed class TalentByIdCompleteSpec : Specification<Talent>
{
    public TalentByIdCompleteSpec(Guid Id)
    {
        Query
            .Where(x => x.Id == Id)
            .Include(talent => talent.Talentgruppe)
            .Include(talent => talent.Steigerungsfaktor)
            .Include(talent => talent.Wurf1)
            .Include(talent => talent.Wurf2)
            .Include(talent => talent.Wurf3)
            .Include(talent => talent.Anwendungsgebiete);
    }
}