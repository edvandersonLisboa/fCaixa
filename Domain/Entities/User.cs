
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : Entity
    {
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Address> Addresses { get; set; } = [];
        public ICollection<Phone> Phones { get; set; } = [];
        public Employee? Employee { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = [];
        public ICollection<UserClaim> UserClaims { get; set; } = [];
    }
}
