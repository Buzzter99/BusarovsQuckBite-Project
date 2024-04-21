using Microsoft.EntityFrameworkCore;

namespace BusarovsQuickBite.Infrastructure.Data.Common
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;

        IQueryable<T> AllReadOnly<T>() where T : class;

        Task AddAsync<T>(T entity) where T : class;

        Task<int> SaveChangesAsync();

        Task<T?> GetByIdAsync<T>(object id) where T : class;

        void DeleteEntity<T>(T entityToDelete) where T : class;

        DbSet<T> GetEntity<T>() where T : class;
    }
}
