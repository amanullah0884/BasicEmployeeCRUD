using BasicAspNet.BusinessLayer.Entity;
using BasicAspNet.Infrastructure.Interface;
using BasicAspNet.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BasicAspNet.Infrastructure.Reporitory
{
    public class AsyncRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        private readonly DbContext _context;
        public AsyncRepository(DbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<T> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Delete(int id)
        {
            var emp =await _context.Set<T>().FirstOrDefaultAsync(s => s.ID == id);
            _context.Remove(emp);
            await _context.SaveChangesAsync();
            return emp;
        }
        public async Task<T> Get(int id)
        {
            return _context.Set<T>().Where(s => s.ID == id).First();
        }

        public Task<List<T>> ListAsync(Expression<Func<T, bool>>? criteria=null)
        {
            if (criteria == null)
            {
                return _context.Set<T>().ToListAsync();
            }
            else
            {
               return _context.Set<T>().Where(criteria).ToListAsync();
            }
        }
    }
}
