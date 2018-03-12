using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
   public class facturaDTO 
    {
        
        public int idFactura { get; set; }
        public Nullable<short> Entrega { get; set; }
        public int Pedido_idPedido { get; set; }
        public string Pedido_Cliente_DNI { get; set; }
        public int Repartidor_idRepartidor { get; set; }
        public int Administrador_idAdministrador { get; set; }


        public facturaDTO(factura f) {
            this.idFactura = f.idFactura;
            this.Entrega = f.Entrega;
            this.Pedido_idPedido = f.Pedido_idPedido;
            this.Pedido_Cliente_DNI = f.Pedido_Cliente_DNI;
            this.Repartidor_idRepartidor = f.Repartidor_idRepartidor;
            this.Administrador_idAdministrador = f.Administrador_idAdministrador;
            

        }
        public facturaDTO(int idFactura, Nullable<short> Entrega, int Pedido_idPedido, string Pedido_Cliente_DNI, int Repartidor_idRepartidor, int Administrador_idAdministrador) {

            this.idFactura = idFactura;
            this.Entrega = Entrega;
            this.Pedido_idPedido = Pedido_idPedido;
            this.Pedido_Cliente_DNI = Pedido_Cliente_DNI;
            this.Repartidor_idRepartidor = Repartidor_idRepartidor;
            this.Administrador_idAdministrador = Administrador_idAdministrador;

        }
        public static facturaDTO pedidoedtoparalinia(DataGridViewCellCollection row)
        {

            return new facturaDTO((int)row["idFactura"].Value,(Nullable<short>)row["Entrega"].Value, (int)row["Pedido_idPedido"].Value, (string)row["Pedido_Cliente_DNI"].Value, (int)row["Repartidor_idRepartidor"].Value, (int)row["Administrador_idAdministrador"].Value);

        }

    }
}
