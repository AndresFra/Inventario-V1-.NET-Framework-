using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventario.Models.ViewModel
{
    public class EquiposViewModel
    {
        public int Id { get; set; }

        [Required/*(ErrorMessage = "El campo nombre es requerido")*/]
       
        [Display(Name = "Empleado")]
        public int empleadoId { get; set; }

        [Required]
       
        [Display(Name = "Marca")]
        public int marcaId { get; set; }

        [Required]
        [StringLength(50)]
     
        public string procesador { get; set; }

        [Required]
        [StringLength(50)]
        //[Display(Name = "localidad")]
        public string memoria { get; set; }

        [Required]
    
        //[Display(Name = "localidad")]
        public int asignacionId { get; set; }

        [Required]
        [StringLength(50)]
        //[Display(Name = "localidad")]
        public string disco { get; set; }

       

        [Required]
        [StringLength(50)]
        //[Display(Name = "localidad")]
        public string serial { get; set; }

        [Required]
   
        [Display(Name = "Modelo")]
        public int modeloId { get; set; }

        [Required]
        
        [Display(Name = "Monitor")]
        public int monitorId { get; set; }

        [Required]

        [Display(Name = "Accesorio")]
        public int accesorioId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FCreacion { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de actualizacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? fActualizacion { get; set; }

        //[Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de despacho")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? fDespacho { get; set; }
    }
}