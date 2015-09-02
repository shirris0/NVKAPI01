using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiCore.Servicios.Impl;
using ApiCore.Servicios;
using ApiCore.Entidades;
using ApiCore.Infraestructura.Exceptions;

namespace ApiSolicitudes.Tests.ServiciosTest
{
    /// <summary>
    /// Descripción resumida de SolicitudServiceTest
    /// </summary>
    [TestClass]
    public class SolicitudServiceTest
    {
        public SolicitudServiceTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        #region TestSolicitud
        [TestMethod]
        public void RegistrarSolicitud() {
            ISolicitudService solicitudService = new SolicitudService();

            int id = solicitudService.Registrar(new Solicitud() {Usuario="IWilson",Descripcion="Descripcion 1"});

            Assert.IsTrue(id>0);
        }


        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void RegistrarSolicitud_SinUsuario()
        {
            ISolicitudService solicitudService = new SolicitudService();

            int id = solicitudService.Registrar(new Solicitud() { Descripcion = "Descripcion 1" });

        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void RegistrarSolicitud_SinDescripcion() {
            ISolicitudService solicitudService = new SolicitudService();
            int id = solicitudService.Registrar(new Solicitud() { Usuario = "IWilson"});
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void RegistrarSolicitud_DescripcionMaximoDeCaracteres()
        {
            ISolicitudService solicitudService = new SolicitudService();
            int id = solicitudService.Registrar(new Solicitud() { Usuario = "IWilson", Descripcion = "Descripcion 1asdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdsdasdssssssssssssssssssssssssssssssssssssssssssssssssssssssssss" });
        }

        [TestMethod]
        public void ActualizarSolicitud() {
            ISolicitudService solicitudService = new SolicitudService();
           bool resultado = solicitudService.Actualizar(new Solicitud() { Id = 1 , Usuario = "IWilson", Descripcion = "Descripcion 1" });

           Assert.IsTrue(resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ActualizarSolicitud_IdNoValido()
        {
            ISolicitudService solicitudService = new SolicitudService();
            bool resultado = solicitudService.Actualizar(new Solicitud() { Id = 10, Usuario = "IWilson", Descripcion = "Descripcion 1" });
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ActualizarSolicitud_SinDescripcion()
        {
            ISolicitudService solicitudService = new SolicitudService();
            solicitudService.Actualizar(new Solicitud() { Id = 1, Usuario = "IWilson", Descripcion = "" });

        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ActualizarSolicitud_DescripcionMaximoDeCaracteres()
        {
            ISolicitudService solicitudService = new SolicitudService();
            solicitudService.Actualizar(new Solicitud() { Id = 1, Usuario = "IWilson", Descripcion = "Descripcion 1asdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdsdasdssssssssssssssssssssssssssssssssssssssssssssssssssssssssss" });
        }

        [TestMethod]
        public void EliminarSolicitud()
        {
            ISolicitudService solicitudService = new SolicitudService();
            bool resultado = solicitudService.Eliminar(1);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void EliminarSolicitud_IdInvalido()
        {
            ISolicitudService solicitudService = new SolicitudService();
            solicitudService.Eliminar(12);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ObtenerSolicitud()
        {
            ISolicitudService solicitudService = new SolicitudService();
            solicitudService.Eliminar(12);
        }

#endregion


        

    }
}
