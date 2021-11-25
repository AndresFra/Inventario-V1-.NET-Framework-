using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventario.Models.ViewModel
{
    public class EmpleadosViewModel
    {
        public int Id { get; set; }

        [Required/*(ErrorMessage = "El campo nombre es requerido")*/]
        [StringLength(50)]
        [Display(Name = "nombre")]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "posicion")]
        public string posicion { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "direccion")]
        public string direccion { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "localidad")]
        public string localidad { get; set; }

        [Required]

        [Display(Name = "codigo")]
        public int codigo { get; set; }
    }
}