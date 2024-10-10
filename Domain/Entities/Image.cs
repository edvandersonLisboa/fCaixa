
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Image : Entity
    {

        public string Url { get; set; } = string.Empty;
        public string Name { get; set; }
        public string extension { get; set; }
        public string Base64 { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; } = [];
    }
}
