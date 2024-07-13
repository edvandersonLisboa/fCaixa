using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class FornecedorViewModel
    {
        public int Id { get; set; }
        public int Empresa { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public IEnumerable<PhoneViewModel> Phone { get; set; }
        public FornecedorRamoDeAtuacaoViewModel RamoDeAtuacao { get; set; }
        public string Descricao { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

    }
}
