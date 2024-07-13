using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class VendaViewModel
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int quantidade { get; set; }
        public Decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }




    }
}
