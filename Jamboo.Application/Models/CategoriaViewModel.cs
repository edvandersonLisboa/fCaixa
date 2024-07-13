using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Application.Models
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da categoria é obrigatório")]
        [Display(Name = "Categoria")]
        public string? Name { get; set; }

        public DateTime Update { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;

    }
}
