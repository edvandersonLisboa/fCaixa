
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Branch : Entity
    {
      
        public string Name { get; set; } = string.Empty;
        public int CompanyId { get; set; } 
        public Company? Company { get; set; }
        public ICollection<Employee> Employees { get; set; } = [];
        public ICollection<Product> Products { get; set; } = [];
    }
}
