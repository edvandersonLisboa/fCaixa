using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class FilialViewModel
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public BrandViewModal Logo { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public IEnumerable<UsuarioViewModel> Clientes { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

    }
}
