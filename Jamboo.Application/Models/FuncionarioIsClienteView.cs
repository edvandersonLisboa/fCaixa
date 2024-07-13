using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class FuncionarioIsClienteView
    {
        #region Chave primary Composta
        public int Id { get; set; }
        public int ClienteId { get; set; }
        #endregion
        public IEnumerable<UsuarioRoleViemModel> Roles { get; set; }
        public int ImageFuncionarioId { get; set; }

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;


        public FuncionarioIsClienteView(int Id, int ClientId, ICollection<UsuarioRoleViemModel> roles, int imageId )
        {
            this.Id = Id;
            this.ClienteId = ClientId;
            this.Update = DateTime.Now;
            this.Roles = roles; 
            this.ImageFuncionarioId = imageId;
            
        }
    }


}
