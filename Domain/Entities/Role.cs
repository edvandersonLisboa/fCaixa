using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Role : Entity
    {
       
        public string Name { get; set; } = string.Empty;
        public ICollection<UserRole> UserRoles { get; set; } = [];
    }
}
