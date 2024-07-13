using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class ContaViewModel
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Preco { get; set; }
        public int TipoContaId { get; set; }
        public DateTime Vencimento { get; set; }
        public int FornecedoId { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

    }
}
