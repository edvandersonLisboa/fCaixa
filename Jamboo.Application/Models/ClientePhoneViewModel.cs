using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class ClientePhoneViewModel
    {
        public int ClienteId { get; set; }
        public int PhoneId { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

        public ClientePhoneViewModel(int clienteId, int phoneId)
        {
            this.ClienteId = clienteId;
            this.PhoneId = phoneId;
            this.Update = DateTime.Now;         
            
        }
    }
}
