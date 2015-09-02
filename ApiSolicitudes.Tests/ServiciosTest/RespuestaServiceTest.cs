using System;
using ApiCore.Entidades;
using ApiCore.Infraestructura.Exceptions;
using ApiCore.Servicios;
using ApiCore.Servicios.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiSolicitudes.Tests.ServiciosTest
{
    [TestClass]
    public class RespuestaServiceTest
    {
        [TestMethod]
        public void AgregarRespuesta()
        {
            IRespuestaService respuestaService = new RespuestaService();

            int id = respuestaService.Registrar(new Respuesta() { Usuario = "IWilson", Solicitud = new Solicitud() { Id=1} });

            Assert.IsTrue(id > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void AgregarRespuesta_SinUsuario()
        {
            IRespuestaService respuestaService = new RespuestaService();

            int id = respuestaService.Registrar(new Respuesta() { Solicitud = new Solicitud() { Id = 1 } });
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void AgregarRespuesta_SinSolicitud()
        {
            IRespuestaService respuestaService = new RespuestaService();

            int id = respuestaService.Registrar(new Respuesta() { Usuario = "IWilson" });
        }

        [TestMethod]
        public void EliminarRespuesta()
        {
            IRespuestaService respuestaService = new RespuestaService();

            bool resultado = respuestaService.Eliminar(1);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void EliminarRespuesta_IdInvalido()
        {
            IRespuestaService respuestaService = new RespuestaService();

            bool resultado = respuestaService.Eliminar(10);
        }
    }
}
