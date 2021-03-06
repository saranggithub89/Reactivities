using System;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
  public class Repository<T> : IRepository<T> where T : class, new()
  {
    private readonly DataContext _context;

    public Repository(DataContext context)
    {
      _context = context;
    }

    public IQueryable<T> GetAll() {
        try {
            return _context.Set<T>();
        } catch(Exception ex) {
            throw new Exception($"Couldn't retrieve entities: {ex.Message}");
        }
    }

    public async Task<T> AddAsync(T entity)
    {
      if(entity == null) {
          throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
      }
      try {
          await _context.AddAsync(entity);
          await _context.SaveChangesAsync();
          return entity;
      } catch(Exception ex) {
          throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
      }
    }

    public async Task<T> UpdateAsync(T entity)
    {
      if(entity == null) {
          throw new ArgumentNullException($"{nameof(UpdateAsync)} entity must not be null");
      }
      try {
          _context.Update(entity);
          await _context.SaveChangesAsync();
          return entity;
      } catch(Exception ex) {
          throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
      }
    }

    public async Task<T> DeleteAsync(T entity)
    {
      if(entity == null) {
          throw new ArgumentNullException($"{nameof(DeleteAsync)} entity must not be null");
      }
      try {
          _context.Remove(entity);
          await _context.SaveChangesAsync();
          return entity;
      } catch(Exception ex) {
          throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
      }
    }

  }
}