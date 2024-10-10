using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repositories.Base;

using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class ClaimRepository : Repository<Claim>, IClaimRepository
    {
        public ClaimRepository(AppSqliteContext dbContext) : base(dbContext)
        {
        }
    }
}
