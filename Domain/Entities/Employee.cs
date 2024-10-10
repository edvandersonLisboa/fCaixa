
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : Entity
    {

        public int BranchId { get; set; }
        public Branch? Branch { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public ICollection<Sale> Sales { get; set; } = [];
    }
}
