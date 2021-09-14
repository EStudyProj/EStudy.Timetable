using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace EStudy.Timetable.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task CreateRangeAsync(List<TEntity> entities);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task UpdateRangeAsync(List<TEntity> entities);
        Task<TEntity> RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(List<TEntity> entities);
        Task<List<TEntity>> GetAllAsync(int count, int offset, bool disableTracking = true);
        Task<TEntity> FirstAsync();
        Task<TEntity> LastAsync();
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> match);
        Task<long> CountLongAsync();
        Task<long> CountLongAsync(Expression<Func<TEntity, bool>> match);
        Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> match);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match, bool disableTracking = true);
        Task<List<TEntity>> FindListAsync(Expression<Func<TEntity, bool>> match, bool disableTracking = true);
        Task<List<TEntity>> FindListAsync(Expression<Func<TEntity, bool>> match, int count, int skip, bool disableTracking = true);
    }
}