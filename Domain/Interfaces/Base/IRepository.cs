using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Base
{
    public interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, bool includeInactive = false);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task RemoveRange(IEnumerable<TEntity> entities);
        Task AddRange(IEnumerable<TEntity> entities);
        Task AddAsync(TEntity entity);//create post async
        Task<IEnumerable<TEntity>> GetAllListAsync(bool includeInactive = false);
        Task Update(TEntity entity);
        Task<int> CountAsync(bool includeInactive = false);
        Task Remove(TEntity entity);
        Task Add(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllPagedAsync(int currentPage, int pageSize, bool includeInactive = false);
        public Task<int> SaveChanges();

    }
}
