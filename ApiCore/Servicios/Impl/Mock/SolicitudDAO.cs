using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiCore.DAO;
using ApiCore.Entidades;

namespace ApiCore.Servicios.Impl.Mock
{
    public class SolicitudDAO : ISolicitudDAO
    {
        static IList<Solicitud> lsolicitudes = new List<Solicitud>();
        static int id = 0;

        public int Guardar(Solicitud solicitud)
        {
            solicitud.Id = ++id;
            lsolicitudes.Add(solicitud);
            return solicitud.Id;
        }

        public bool Actualizar(Solicitud solicitud) {

           Solicitud solicitudEncontrada =  lsolicitudes.Where(x => x.Id == solicitud.Id).FirstOrDefault();
           if (solicitudEncontrada != null) {
               solicitudEncontrada.Descripcion = solicitud.Descripcion;
               if (lsolicitudes.Where(x => x.Id == solicitud.Id).FirstOrDefault().Descripcion == solicitud.Descripcion)
               {
                   return true;
               }
               else {
                   return false;
               }
           }
           else {
               return false;
           }
        }

        public bool Eliminar(int Id) {

            Solicitud solicitudEncontrada = lsolicitudes.Where(x => x.Id == Id).FirstOrDefault();
            if (solicitudEncontrada == null)
            {
                return false;
            }
            else { 
                bool respuesta = lsolicitudes.Remove(solicitudEncontrada);
                return respuesta;
            }
           
        }
    }
}
