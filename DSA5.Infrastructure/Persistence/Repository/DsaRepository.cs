using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using DSA5.Application.Common.Persistence;
using DSA5.Entities.Common.Contracts;
using DSA5.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DSA5.Infrastructure.Persistence.Repository;

public class DsaRepository<T> : RepositoryBase<T>, IRepository<T> where T : class, IEntity
{
    public DsaRepository(DsaDbContext dbContext) : base(dbContext)
    {
    }

    public DsaRepository(DsaDbContext dbContext, ISpecificationEvaluator specificationEvaluator) : base(dbContext, specificationEvaluator)
    {
    }
}