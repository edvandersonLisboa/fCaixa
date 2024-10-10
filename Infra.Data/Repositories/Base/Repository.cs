using Domain.Interfaces.Base;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Shared.Entities;
using Shared.Queriables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly AppSqliteContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(AppSqliteContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual async Task Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
      
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);

        }

        public virtual async Task AddRange(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);


        }

        public virtual async Task<int> CountAsync(bool includeInactive = false)
        {
            var count = 0;
            if (includeInactive)
                count = await _dbSet
                    .CountAsync();
            else
                  count = await _dbSet
                    .Where(Queriable<TEntity>.GetIfActive())
                    .CountAsync();

            return count;
        }

        public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, bool includeInactive = false)
        {
            var result = await _dbSet.Where(predicate).ToListAsync();

            return result;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllListAsync(bool includeInactive = false)
        {
            var result = new List<TEntity>();
            if (includeInactive)
                result = await _dbSet
                    .AsNoTracking()
                    .ToListAsync();
            else
                result = await _dbSet
                    .AsNoTracking()
                    .Where(Queriable<TEntity>.GetIfActive())
                    .ToListAsync();

            return result;
        }


        public async Task<IEnumerable<TEntity>> GetAllPagedAsync(int currentPage, int pageSize, bool includeInactive = false)
        {
            int amountToTake = (currentPage - 1) * pageSize;
            var result = new List<TEntity>();
            if (includeInactive)
                result = await _dbSet
                    .AsNoTracking()
                    .Skip(amountToTake)
                    .Take(pageSize)
                    .ToListAsync();
            else
                result = await _dbSet
                .AsNoTracking()
                .Where(Queriable<TEntity>.GetIfActive())
                .Skip(amountToTake)
                .Take(pageSize)
                .ToListAsync();


            return result;
        }



        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            TEntity? entity = await _dbSet
                .SingleOrDefaultAsync(Queriable<TEntity>.GetById(id));


            return entity;
        }

        public virtual async Task Remove(TEntity entity)
        {
            _dbSet.Remove(entity);

        }

        public virtual async Task RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);

        }

        public virtual async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var result = await _dbSet
                .Where(predicate)
                .FirstOrDefaultAsync();


            return result;
        }

        public virtual async Task Update(TEntity entity)
        {
            var result = _dbSet.Update(entity);

        }

        public async Task<int> SaveChanges()
        {
            try
            {
                var affectedLines = await _context.SaveChangesAsync();

                return affectedLines;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
