using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Phone : Entity
    {
       
        public string Number { get; set; } = string.Empty;
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
