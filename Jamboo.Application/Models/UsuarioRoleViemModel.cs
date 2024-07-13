using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class UsuarioRoleViemModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

        public UsuarioRoleViemModel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Update = DateTime.Now;

        }
    }
}
