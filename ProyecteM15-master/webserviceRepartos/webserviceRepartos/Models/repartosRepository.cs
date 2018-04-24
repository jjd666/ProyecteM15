using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webserviceRepartos.Models
{
    public class repartosRepository
    {
        private static repartosssEntities1 dataContext = new repartosssEntities1();

        //muestra clientes con pedidos no entregados
        public static List<cliente> GetAllContactes()
        {
            List<cliente> lc = dataContext.pedido.Where(x => x.cliente_DNI.Equals(x.cliente.DNI)&& x.Entregado.Equals("NO"))
                   .OrderBy(x=>x.FechaPedido).Select(x => x.cliente).ToList();

            return lc;
        }

        //muestra clientes por dni
        public static cliente GetContacte(String contacteID)
        {
            cliente c = dataContext.cliente.Where(x => x.DNI.Equals(contacteID)).SingleOrDefault();
            return c;
        }

        //Lista de todos los repartidores
        public static List<repartidor> GetRepart()
        {
            List<repartidor> a = dataContext.repartidor.ToList();
            return a;
        }
        //Obtener lista repartidores no activos
        public static List<repartidor> GetRepartidoresNoActivos()
        {
            List<repartidor> lista = dataContext.repartidor.Where(x => x.Activo.Equals(false)).ToList();

            return lista;
        }

        //muestra clientes por nombre
        public static List<cliente> SearchContactesByName(string contacteName)
        {
            List<cliente> lc = dataContext.cliente.Where(x => x.Nombre.Contains(contacteName)).ToList();
            return lc;
        }

        //Actualiza la entrega de un pedido de un cliente seleccionado
        public static cliente UpdateContacte(String dni, pedido c)
        {
            try
            {
                pedido c0 = dataContext.pedido.Where(x => x.cliente_DNI.Equals(dni)).SingleOrDefault();
                c0.Entregado = "si";


                dataContext.SaveChanges();
                return GetContacte(dni);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        //añade un nuevo cliente
        public static cliente InsertContacte(cliente c)
        {
            try
            {
                dataContext.cliente.Add(c);
                dataContext.SaveChanges();
                return GetContacte(c.DNI);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Elimina un cliente por dni
        public static void DeleteContacte(int id)
        {
            cliente c = dataContext.cliente.Where(x => x.DNI.Equals (id)).SingleOrDefault();
            if (c != null)
            {
                dataContext.cliente.Remove(c);
                dataContext.SaveChanges();
            }
        }

        public static List<pedido> searchpktclient(String dni)
        {

            List<pedido> LP = dataContext.pedido.Where(x => x.cliente_DNI.Equals(dni)).ToList();
            return LP;

        }
        public static pedido onepkt(string dni, int a)
        {

            pedido LP = dataContext.pedido.Where(x => x.cliente_DNI.Equals(dni) && x.idPedido == a).FirstOrDefault();
            return LP;

        }

    }
}
