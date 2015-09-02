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
    public class RespuestaService : IRespuestaService
    {
        int IRespuestaService.Registrar(Entidades.Respuesta respuesta)
        {
            IRespuestaDAO res = new RespuestaDAO();
            if (String.IsNullOrEmpty(respuesta.Usuario)) {
                throw new BusinessException("El usuario es requerido");
            } if (respuesta.Solicitud == null) {
                throw new BusinessException("La solicitud es requerida");
            }
            int resultado = res.Guardar(respuesta);

            return resultado;
        }

        bool IRespuestaService.Eliminar(int id)
        {
            IRespuestaDAO res = new RespuestaDAO();

            bool resultado = res.Eliminar(id);
            if (resultado == false) {
                throw new BusinessException("Id Inválido");
            }

            return resultado;
        }
    }
}
