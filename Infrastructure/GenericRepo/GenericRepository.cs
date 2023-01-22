using GenericRepositoryWithSpecificationExample.Core.Data;
using GenericRepositoryWithSpecificationExample.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GenericRepositoryWithSpecificationExample.Infrastructure.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
