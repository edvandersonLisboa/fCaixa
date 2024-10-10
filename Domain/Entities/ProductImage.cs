using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductImage : Entity
    {
        
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int ImageId { get; set; }
        public Image? Image { get; set; }
    }
}
