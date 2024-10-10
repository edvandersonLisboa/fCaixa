using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserClaim : Entity
    {

        public int UserId { get; set; }
        public User? User { get; set; }

        public int ClaimId { get; set; }
        public Claim? Claim { get; set; }
    }
}
