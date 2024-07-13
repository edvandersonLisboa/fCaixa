using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class EnderecoViewModel
    {
        public int Id { get; set; }
        public string? Rua { get; set; }
        public string? Bairro { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Complemento  { get; set; }
        public string? Codigo_postal { get; set; }
        public string? Numero { get; set; }

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
    }
}
