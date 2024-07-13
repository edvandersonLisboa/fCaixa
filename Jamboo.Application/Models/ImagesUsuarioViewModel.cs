using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class ImagesUsuarioViewModel
    {
        #region Chave Primary Composta
        public int ClienteId { get; set; }
        public int ImageId { get; set; }
        #endregion
        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

        public ImagesUsuarioViewModel( int clienteId, int imageId)
        {
            this.ImageId = imageId;
            this.ClienteId = clienteId;
            this.Update = DateTime.Now;
        }
    }
}