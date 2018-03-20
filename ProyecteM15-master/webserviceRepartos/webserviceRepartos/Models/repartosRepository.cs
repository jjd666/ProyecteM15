using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webserviceRepartos.Models
{
    public class repartosRepository
    {

        private static RepartosEntities dataContext = new RepartosEntities();
        public static List<cliente> GetAllContactes()
        {


            List<cliente> lc = dataContext.pedidoes.Where(x => x.cliente_DNI.Equals(x.cliente.DNI)&& x.Entregado.Equals("NO"))
                   .OrderBy(x=>x.FechaPedido).Select(x => x.cliente).ToList();

        
            return lc;
        }

        public static cliente GetContacte(String contacteID)
        {
            cliente c = dataContext.clientes.Where(x => x.DNI.Equals(contacteID)).SingleOrDefault();
            return c;
        }

        public static List<cliente> SearchContactesByName(string contacteName)
        {
            List<cliente> lc = dataContext.clientes.Where(x => x.Nombre.Contains(contacteName)).ToList();
            return lc;
        }
        public static cliente InsertContacte(cliente c)
        {
            try
            {
                dataContext.clientes.Add(c);
                dataContext.SaveChanges();
                return GetContacte(c.DNI);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static cliente UpdateContacte(String dni, pedido c)
        {
            try
            {
                pedido c0 = dataContext.pedidoes.Where(x => x.cliente_DNI.Equals (dni)).SingleOrDefault();
                c0.Entregado = "si";


                dataContext.SaveChanges();
                return GetContacte(dni);

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<repartidor> GetRepart()
        {
            List<repartidor> a = dataContext.repartidors.ToList();
            return a;
        }




        public static void DeleteContacte(int id)
        {
            cliente c = dataContext.clientes.Where(x => x.DNI.Equals (id)).SingleOrDefault();
            if (c != null)
            {
                dataContext.clientes.Remove(c);
                dataContext.SaveChanges();
            }
        }
    }





}
