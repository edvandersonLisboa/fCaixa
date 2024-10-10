using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositories
{
    public interface ILegacyRepository<TEntity, TLegacyEntity> where TEntity : Entity where TLegacyEntity : LegacyEntity<TEntity>
    {
        Task<IEnumerable<TLegacyEntity>> ReadAllAsync(string connectionString);
    }
}
