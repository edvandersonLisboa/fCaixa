using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SaleProduct : Entity
    {

        public int SaleId { get; set; }
        public Sale? Sale { get; set; }
        public int ProductPriceId { get; set; }
        public ProductPrice? ProductPrice { get; set; }
        public decimal Descount { get; set; }
    }
}
