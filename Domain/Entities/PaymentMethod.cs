using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentMethod : Entity
    {
        public string Type { get; set; } = string.Empty;
        public int SaleId { get; set; }
        public Sale? Sale { get; set; }
    }
}
