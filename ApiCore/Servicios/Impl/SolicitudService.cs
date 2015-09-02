using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiCore.DAO;
using ApiCore.Infraestructura.Exceptions;
using ApiCore.Servicios.Impl.Mock;

namespace ApiCore.Servicios.Impl
{
    public class SolicitudService : ISolicitudService
    {


        public int Registrar(Entidades.Solicitud solicitud)
        {
            solicitud.FechaRegistro = DateTime.Today;
            ISolicitudDAO sol = new SolicitudDAO();
            if (String.IsNullOrEmpty(solicitud.Usuario)) {
                throw new BusinessException("No hay usuario");
            } if (String.IsNullOrEmpty(solicitud.Descripcion)) {
                throw new BusinessException("No hay descripcion");
            } if (solicitud.Descripcion.Length > 140) {
                throw new BusinessException("La descripción excede el número de caracteres");
            }
            
            return sol.Guardar(solicitud);
        }

        public bool Actualizar(Entidades.Solicitud solicitud)
        {
            ISolicitudDAO sol = new SolicitudDAO();
            if (String.IsNullOrEmpty(solicitud.Descripcion)) {
                throw new BusinessException("El dato descripcion es obligatorio");
            } if (solicitud.Descripcion.Length > 140)
            {
                throw new BusinessException("La descripción excede el número de caracteres");
            }
            bool resultado = sol.Actualizar(solicitud);
            if (resultado == false) {
                throw new BusinessException("No se pudo actualziar la solicitud");
            }
            return resultado;
        }

        public bool Eliminar(int id)
        {
            ISolicitudDAO sol = new SolicitudDAO();

            if (id < 1) {
                throw new BusinessException("El Id no es válido");
            }
            bool respuesta = sol.Eliminar(id);
            if (respuesta == false) {
                throw new BusinessException("No se puede eliminar la solicitud");
            }
            return respuesta;
        }
    }
}
