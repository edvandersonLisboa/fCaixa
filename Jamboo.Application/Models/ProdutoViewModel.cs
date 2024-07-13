using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Preco { get; set; }

        public IEnumerable<ProdutoCorMarcaViewModel> infos { get; set; }
        public IEnumerable<CategoriaProdutoViewModel> Categorias { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
    }
}
