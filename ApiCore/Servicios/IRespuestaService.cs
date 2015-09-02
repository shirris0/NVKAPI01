using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiCore.Entidades;

namespace ApiCore.Servicios
{
   public interface IRespuestaService
    {
        int Registrar(Respuesta respuesta);

        bool Eliminar(int id);
    }
}
