using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroNotas
{
    class Estudiante
    {
        private string codigoEstudiante;       
        private string nombres;
        private string apellidos;

        public string CodigoEstudiante
        {
            get { return codigoEstudiante; }
            set { codigoEstudiante = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

    }
}
