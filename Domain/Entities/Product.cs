
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : Entity
    {
    
        public string Name { get; set; } = string.Empty;
        public int BranchId { get; set; }
        public Branch? Branch { get; set; }
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int ColorId { get; set; }
        public Color? Color { get; set; } 
        public ICollection<ProductSize> ProductSizes { get; set; } = [];
        public ICollection<ProductImage> ProductImages { get; set; } = [];
        public int ProdutoPriceId { get; set; }
        public ProductPrice? ProductPrice { get; set; }
        public ICollection<SaleProduct> SaleProducts { get; set; } = [];
    }
}
