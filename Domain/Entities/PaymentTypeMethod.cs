using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentTypeMethod : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Descript { get; set; } = string.Empty;
    }
}
