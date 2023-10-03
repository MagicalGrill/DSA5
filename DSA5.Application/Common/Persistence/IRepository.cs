using Ardalis.Specification;
using DSA5.Entities.Common.Contracts;

namespace DSA5.Application.Common.Persistence;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IEntity
{
    
}