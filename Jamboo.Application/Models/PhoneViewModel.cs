using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class PhoneViewModel
    {
        public int Id { get; set; }

        public string Numero { get; set; }

        public string CodigoPais { get; set; }
        public string CodigoRegiao { get; set; }

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

        public PhoneViewModel(int Id, string numero, string codigoRegiao, string codigoPais)
        {
            this.Id = Id;
            this.Numero = numero;
            this.Update = DateTime.Now;
            this.CodigoRegiao = codigoRegiao;
            this.CodigoPais = codigoPais;
             
        }

    }
}
