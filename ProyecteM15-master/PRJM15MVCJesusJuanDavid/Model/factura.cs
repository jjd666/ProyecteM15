//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class factura
    {
        public int idFactura { get; set; }
        public Nullable<short> Entrega { get; set; }
        public int Pedido_idPedido { get; set; }
        public string Pedido_Cliente_DNI { get; set; }
        public int Repartidor_idRepartidor { get; set; }
        public int Administrador_idAdministrador { get; set; }
    
        public virtual administrador administrador { get; set; }
        public virtual pedido pedido { get; set; }
        public virtual repartidor repartidor { get; set; }
    }
}