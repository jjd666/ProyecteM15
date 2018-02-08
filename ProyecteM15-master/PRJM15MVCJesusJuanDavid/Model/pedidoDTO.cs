using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class pedidoDTO
    {
        public int idPedido { get; set; }
        public System.DateTime FechaPedido { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public string Entregado { get; set; }
        public string Decripcion { get; set; }
        public string cliente_DNI { get; set; }

        public pedidoDTO(int idPedido, System.DateTime FechaPedido, System.DateTime FechaEntrega, string Entregado, string Decripcion,string cliente_DNI) {
            this.idPedido = idPedido;
            this.FechaPedido = FechaPedido;
            this.FechaEntrega = FechaEntrega;
            this.Entregado = Entregado;
            this.Decripcion = Decripcion;
            this.cliente_DNI = cliente_DNI;

        }
        public pedidoDTO(pedido P)
        {
            this.idPedido = P.idPedido;
            this.FechaPedido = P.FechaPedido;
            this.FechaEntrega = P.FechaEntrega;
            this.Entregado = P.Entregado;
            this.Decripcion = P.Decripcion;
            this.cliente_DNI = P.cliente_DNI;

        }
        public static pedidoDTO pedidoedtoparalinia(DataGridViewCellCollection row)
        {

            return new pedidoDTO((int)row["idPedido"].Value,(System.DateTime)row["FechaPedido"].Value, (System.DateTime)row["FechaEntrega"].Value, (string)row["Entregado"].Value, (string)row["Decripcion"].Value, (string)row["cliente_DNI"].Value);

        }
    }
}

    
