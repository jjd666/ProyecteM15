using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webserviceRepartos.Models
{
    public class repartosRepository
    {

        private static repartosssEntities dataContext = new repartosssEntities();
        public static List<cliente> GetAllContactes()
        {
            //var qq = from c in dataContext.clientes
            //         join p in dataContext.pedidoes on c.DNI equals p.cliente_DNI
            //         where (p.Entregado == "NO")
            //         orderby p.FechaPedido
            //         select new { c.DNI, c.Nombre, c.Telefono, c.Direccion };

            //List<cliente>

            List<cliente> lc = dataContext.pedidoes.Where(x => x.cliente_DNI.Equals(x.cliente.DNI)&& x.Entregado.Equals("NO"))
                   .OrderBy(x=>x.FechaPedido).Select(x => x.cliente).ToList();

           // List<cliente> lc = dataContext.pedidoes.Where(x => x.cliente_DNI.Equals(x.cliente.DNI) && x.Decripcion.Equals("MAL"))
                   //.OrderBy(x => x.FechaPedido).Select(x => x.cliente).ToList();




            //List<cliente> s = qq.ToList();
            //List < cliente > lc = dataContext.clientes.ToList();
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
