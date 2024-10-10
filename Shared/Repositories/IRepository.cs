using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task CreateAsync(TEntity entity);
        Task<TEntity?> GetById(int id);
        Task<TEntity?> GetByIdNoTrackingAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync(bool includeInactive = false);
        Task<IEnumerable<TEntity>> GetAllPagedAsync(int currentPage, int pageSize, bool includeInactive = false);
        Task<int> CountAllAsync(bool includeInactive = false);
        Task UpdateAsync(TEntity entity);
        void Delete(TEntity entity);
    }
}
