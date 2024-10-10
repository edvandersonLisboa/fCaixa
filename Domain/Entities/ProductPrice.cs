using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductPrice : Entity
    {
        public string sku { get; set; }
        public string qrCode { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public decimal Price { get; set; }
        public decimal  CostPrice { get; set; }
        public decimal amountMin { get; set; }
        public decimal amount { get; set; }
        public ICollection<SaleProduct> SaleProducts { get; set; } = [];
    }
}
