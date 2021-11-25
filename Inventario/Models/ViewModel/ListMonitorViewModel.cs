using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.Models.ViewModel
{
    public class ListMonitorViewModel
    {
        public int Id { get; set; }
        public string marca { get; set; }
        public string serial { get; set; }
        public string modelo { get; set; }
        public string tamaño { get; set; }
        public int cantidad { get; set; }
    }
}