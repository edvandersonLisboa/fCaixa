using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppSqliteContext dbContext) : base(dbContext)
        {
        }
    }
}
