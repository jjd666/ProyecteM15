using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webserviceRepartos.Models;

namespace webserviceRepartos.Controllers
{
    public class RepartosController : ApiController
    {

        // GET: api/contactes

            //get de clientes con pedidos no entregados
        [Route("api/clientes")]
        public HttpResponseMessage Get()
        {
            var contactes = repartosRepository.GetAllContactes();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactes);
            return response;
        }

            // put de cuando se completa la entrega de un pedido (cambia el estado de entrega del pedido)
        [Route("api/clientes/{id?}")]
        public HttpResponseMessage Put(String id, [FromBody]pedido val)
        {
            var contacte = repartosRepository.UpdateContacte(id, val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contacte);
            return response;
        }

            //muestra todos los repartidores
        [Route("api/repartidores")]
        public HttpResponseMessage getrep()
        {
            var contactes = repartosRepository.GetRepart();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactes);
            return response;
        }


        [Route("api/cliente/{id}")]
        public HttpResponseMessage getclitone(string id)
        {

            var cliente = repartosRepository.GetContacte(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, cliente);
            return response;

        }


        [Route("api/pktcliente/{id}")]
        public HttpResponseMessage getpktclient(string id)
        {

            List<pedido> a = repartosRepository.searchpktclient(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, a);
            return response;

        }
        [Route("api/pktclienteone/{dni}/{a}")]
        public HttpResponseMessage getonepktclient(string dni, int a)
        {
            pedido b = repartosRepository.onepkt(dni, a);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, b);
            return response;
        }

    }

}
