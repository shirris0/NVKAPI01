using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCore.Entidades
{
   public class Solicitud
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
        private string m_Descripcion;

        public string Descripcion
        {
            get { return m_Descripcion; }
            set { m_Descripcion = value; }
        }
        private DateTime m_FechaRegistro;

        public DateTime FechaRegistro
        {
            get { return m_FechaRegistro; }
            set { m_FechaRegistro = value; }
        }
    }
}
