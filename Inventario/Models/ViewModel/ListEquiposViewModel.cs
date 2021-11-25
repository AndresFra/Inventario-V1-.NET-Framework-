using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Models.ViewModel
{
    public class ListEquiposViewModel
    {
        public int Id { get; set; }
        public string Empleado { get; set; }
        public int empleadoId { get; set; }
        public string Marca { get; set; }
        public int marcaId { get; set; }
        public string procesador { get; set; }
        public string memoria { get; set; }
        public string disco { get; set; }
        public string Asignacion { get; set; }
        public int asignacionId { get; set; }
        public string serial { get; set; }
        public string Modelo { get; set; }
        public int modeloId { get; set; }
        public string Monitor { get; set; }
        public int monitorId { get; set; }
        public string Accesorio { get; set; }
        public int accesorioId { get; set; }
        //public DateTime fCreacion { get; set; }
        //public DateTime fActualizacion { get; set; }
        //public DateTime fDespacho { get; set; }


    }
}