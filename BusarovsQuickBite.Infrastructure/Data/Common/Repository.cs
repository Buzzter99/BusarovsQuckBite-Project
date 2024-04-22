using Microsoft.EntityFrameworkCore;

namespace BusarovsQuickBite.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public DbSet<T> GetEntity<T>() where T : class
        {
            return _context.Set<T>();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return GetEntity<T>();
        }

        public IQueryable<T> AllReadOnly<T>() where T : class
        {
            return GetEntity<T>()
                .AsNoTracking();
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await GetEntity<T>().AddAsync(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public async Task<T?> GetByIdAsync<T>(object id) where T : class
        {
            return await GetEntity<T>().FindAsync(id);
        }
        public void DeleteEntity<T>(T entityToDelete) where T : class
        {
            GetEntity<T>().Remove(entityToDelete);
        }
    }
}
