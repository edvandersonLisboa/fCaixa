using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class TamanhoProdutoViewModel
    {
        public int Id { get; set; }
        public string Tamanho { get; set; }

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
    }
}
