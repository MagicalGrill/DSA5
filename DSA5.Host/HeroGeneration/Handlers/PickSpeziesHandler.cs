using DSA5.Application.Common.Persistence;
using DSA5.Entities.Welt;

namespace DSA5.Host.HeroGeneration.Handlers;

public class PickSpeziesHandler
{
    public async Task<Spezies?> Handle(IRepository<Spezies> speziesKatalog)
    {
        return await speziesKatalog.GetByIdAsync(1);
    }
}