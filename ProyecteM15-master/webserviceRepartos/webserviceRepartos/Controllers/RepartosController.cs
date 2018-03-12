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
        [Route("api/contactes")]
        public HttpResponseMessage Get()
        {
            var contactes = repartosRepository.GetAllContactes();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contactes);
            return response;
        }

        [Route("api/contacte/{id?}")]
        public HttpResponseMessage Put(String id, [FromBody]pedido val)
        {
            var contacte = repartosRepository.UpdateContacte(id, val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, contacte);
            return response;
        }

    }
}
