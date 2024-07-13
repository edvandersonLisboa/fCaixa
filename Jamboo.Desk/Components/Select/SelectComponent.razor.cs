using Jamboo.Application.Models;
using Jamboo.Desk.Components.Objetos;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamboo.Desk.Components.Select
{
    partial class SelectComponent 
    {
        public string Label { get; set; } = string.Empty;
        public IEnumerable<UsuarioViewModel> Usuarios { get; set; }


    }
}
