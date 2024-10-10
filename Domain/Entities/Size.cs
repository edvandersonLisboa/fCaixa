
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Size : Entity
    {
       
        public string Description { get; set; } = string.Empty;
        public ICollection<ProductSize> ProductSizes { get; set; } = [];
    }
}
