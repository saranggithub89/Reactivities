using System;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
  public interface IRepository<T> where T : class, new()
  {
    IQueryable<T> GetAll();

    Task<T> AddAsync(T entity);

    Task<T> UpdateAsync(T entity);

    Task<T> DeleteAsync(T entity);
    
  }
}