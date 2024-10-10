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
    public class PaymentStatusRepository : Repository<PaymentStatus>, IPaymentStatusRepository
    {
        public PaymentStatusRepository(AppSqliteContext dbContext) : base(dbContext)
        { }
    }
}
