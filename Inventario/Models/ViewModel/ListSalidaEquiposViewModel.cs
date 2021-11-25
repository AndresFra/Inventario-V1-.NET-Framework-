using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Models.ViewModel
{
    public class ListSalidaEquiposViewModel
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string serial { get; set; }
        public string Modelo { get; set; }
        public string Empleado { get; set; }
        public DateTime FechaDespacho { get; set; }
        public int EquipoId { get; set; }

    }
}