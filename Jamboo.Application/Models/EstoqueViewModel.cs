using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class EstoqueViewModel
    {
        public int Id { get; set; }
        public string  NomeProduto { get; set; }

        public CorViewModel Cor { get; set; }

        public TamanhoProdutoViewModel Tamanho { get; set; }

        public Decimal PrecoUnitario { get; set; }
        public Decimal Total { get; set; }

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
    }
}
