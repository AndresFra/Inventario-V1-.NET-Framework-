using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventario.Models.ViewModel
{
    public class MonitorViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "marca")]
        public string marca { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "serial")]
        public string serial { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "modelo")]
        public string modelo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "tamaño")]
        public string tamaño { get; set; }

        [Required]
     
        [Display(Name = "cantidad")]
        public int cantidad { get; set; }
    }
}