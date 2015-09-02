using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCore.Entidades
{
    public class Respuesta
    {
        private int m_Id;

        public int Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }
        private string m_Usuario;

        public string Usuario
        {
            get { return m_Usuario; }
            set { m_Usuario = value; }
        }
        private Solicitud m_solicitud;

        public Solicitud Solicitud
        {
            get { return m_solicitud; }
            set { m_solicitud = value; }
        }
    }
}
