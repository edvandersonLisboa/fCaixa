using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class FornecedorPhoneViewModel
    {
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public int PhoneId { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
    }
}
