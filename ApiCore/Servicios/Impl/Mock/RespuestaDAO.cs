using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiCore.DAO;
using ApiCore.Entidades;

namespace ApiCore.Servicios.Impl.Mock
{
   public class RespuestaDAO : IRespuestaDAO
    {
       static IList<Respuesta> lrespuestas = new List<Respuesta>();
        static int id = 0;
        int IRespuestaDAO.Guardar(Entidades.Respuesta respuesta)
        {
            respuesta.Id = ++id;
            lrespuestas.Add(respuesta);
            return respuesta.Id;
        }

        bool IRespuestaDAO.Eliminar(int id)
        {
            Respuesta respuesta = lrespuestas.Where(x => x.Id == id).FirstOrDefault();
            bool resultado = lrespuestas.Remove(respuesta);

            return resultado;
        }
    }
}
