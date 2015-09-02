using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiCore.Entidades;

namespace ApiCore.Servicios
{
    public interface ISolicitudService
    {
        int Registrar(Solicitud solicitud);

        bool Actualizar(Solicitud solicitud);

        bool Eliminar(int id);
    }
}
