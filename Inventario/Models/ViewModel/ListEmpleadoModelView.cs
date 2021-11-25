using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Models.ViewModel
{
    public class ListEmpleadoModelView
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string posicion { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public int codigo { get; set; }
    }
}