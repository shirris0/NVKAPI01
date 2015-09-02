using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiCore.Entidades;
using ApiCore.Infraestructura.Exceptions;
using ApiCore.Servicios;
using ApiCore.Servicios.Impl;

namespace ApiSolicitudes.Controllers
{
    public class SolicitudesController : ApiController
    {
        ISolicitudService solicitudService = new SolicitudService();
        // GET api/solicitudes
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/solicitudes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/solicitudes
        public HttpResponseMessage Post(Solicitud solicitud)
        {
            try
            {
                int respuesta = solicitudService.Registrar(solicitud);
                return Request.CreateResponse<int>(HttpStatusCode.OK, respuesta);
            }
            catch (BusinessException e)
            {

                return Request.CreateResponse<string>(HttpStatusCode.BadRequest, e.Message);
            }
            catch (Exception e) {
                return Request.CreateResponse<string>(HttpStatusCode.BadRequest, "Ocurrio un error");
            }
        }

        // PUT api/solicitudes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/solicitudes/5
        public void Delete(int id)
        {
        }
    }
}
