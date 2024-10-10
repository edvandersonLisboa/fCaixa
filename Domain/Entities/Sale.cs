using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sale : Entity
    {
       
        public DateTime SaleDate { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public ICollection<SaleProduct> SaleProducts { get; set; } = [];
        public ICollection<PaymentMethod> PaymentMethods { get; set; } = [];
        public PaymentStatus? Status { get; set; }
    }
}
