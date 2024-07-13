using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class ImageViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

        public ImageViewModel(int id, string name)
        {
            this.Id = id;
            this.Nome = name;
            this.Update = DateTime.Now;
            
        }
    }
}
