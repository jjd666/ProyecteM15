//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjecteM15Part1MVVMv0._1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class administrador
    {
        public administrador()
        {
            this.factura = new HashSet<factura>();
        }
    
        public int idAdministrador { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> FechaContratacion { get; set; }
        public string DNI { get; set; }
    
        public virtual ICollection<factura> factura { get; set; }
    }
}
