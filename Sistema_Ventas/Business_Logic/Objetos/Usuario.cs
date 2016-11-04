using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Objetos
{
    class Usuario
    {
        public int Cedula { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }

        Perfil Perfil = new Perfil();
        public int Estado { get; set; }
    }
}
