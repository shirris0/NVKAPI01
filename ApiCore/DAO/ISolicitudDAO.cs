using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiCore.Entidades;

namespace ApiCore.DAO
{
   public interface ISolicitudDAO
    {
       int Guardar(Solicitud solicitud);
       bool Actualizar(Solicitud solicitud);
       bool Eliminar(int id);
    }
}
