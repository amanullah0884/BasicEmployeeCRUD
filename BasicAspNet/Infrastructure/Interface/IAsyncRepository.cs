using System.Linq.Expressions;

namespace BasicAspNet.Infrastructure.Interface
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<T> Get(int id);
        Task<List<T>> ListAsync(Expression<Func<T, bool>>? criteria=null);
    }
}