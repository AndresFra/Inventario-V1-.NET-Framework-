//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RolAdmin
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public int IdConsulta { get; set; }
    
        public virtual Rol Rol { get; set; }
        public virtual RolConsulta RolConsulta { get; set; }
    }
}
