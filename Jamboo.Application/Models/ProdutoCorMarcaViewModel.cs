using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class ProdutoCorMarcaViewModel
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int TamanhoId { get; set; }
        public int CorId { get; set; }
        public int MarcaId { get; set; }
        public string? Descricao { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
    }
}
