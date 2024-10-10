using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Queriables.Base
{
    public class Queriable<TEntity> where TEntity : Entity
    {
        

        public static Expression<Func<TEntity, bool>> GetIfActive()
        {
            return x => x.IsActive;
        }

        public static Expression<Func<TEntity, bool>> GetById(int id)
        {
            return x => x.Id == id;
        }
    }
}
