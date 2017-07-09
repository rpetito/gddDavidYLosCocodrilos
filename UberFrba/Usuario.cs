using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    static class Usuario
    {
        private static Int32 idUsuario = -1;
        private static Int32 rolUsuarioSeleccionado = -1;


        public static Int32 IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
            
        }

        public static Int32 RolUsuario
        {
            get { return rolUsuarioSeleccionado; }
            set { rolUsuarioSeleccionado = value; }

        }
    }
   
}
