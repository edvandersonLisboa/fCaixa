using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repositories.Base;

namespace Infra.Data.Repositories
{
    public class UserClaimRepository : Repository<UserClaim>, IUserClaimRepository
    {
        public UserClaimRepository(AppSqliteContext dbContext) : base(dbContext)
        { }
    }
}
