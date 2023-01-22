using GenericRepositoryWithSpecificationExample.Core.Models;
using System.Linq.Expressions;

namespace GenericRepositoryWithSpecificationExample.Infrastructure.GenericRepo
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAll();
        Task<IReadOnlyList<T>> GetAll(Expression<Func<T, bool>> predicate);
        Task<T> GetById(int id);
    }
}
