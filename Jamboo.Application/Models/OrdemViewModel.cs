using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class OrdemViewModel
    {
        public int Id { get; set; }
        public IEnumerable<ProdutoItemViewModel> itens { get; set; }

        public Decimal ValorTotal { get; set; }

        public StatusVendaViewModel Satus { get; set; }

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
    }
}
