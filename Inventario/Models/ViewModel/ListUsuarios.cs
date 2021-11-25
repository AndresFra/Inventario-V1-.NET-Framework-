using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Models.ViewModel
{
    public class ListUsuarios
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        public string Email { get; set; }

        public string Rol { get; set; }
        public int idRol { get; set; }

    }
}