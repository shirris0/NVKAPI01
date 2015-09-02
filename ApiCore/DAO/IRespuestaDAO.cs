using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiCore.Entidades;

namespace ApiCore.DAO
{
   public interface IRespuestaDAO
    {
        int Guardar(Respuesta respuesta);
        bool Eliminar(int id);

    }
}
