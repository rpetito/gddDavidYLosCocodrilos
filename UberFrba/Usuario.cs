using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class Usuario
    {
        public static Usuario instance = null;

        private Decimal dni = -1;
        private List<Rol> roles = new List<Rol>();
        private Rol rolSeleccionado = null;

        public static Usuario getInstance()
        {
            if (instance == null)
            {
                instance = new Usuario();
            }

            return instance;
        }


        public void setDNI(Decimal dni)
        {
            this.dni = dni;
        }

        public void addRol(Rol rol)
        {
            if (!this.roles.Contains(rol)) {
                this.roles.Add(rol);
            }
        }

        public List<Rol> getRoles()
        {
            return this.roles;
        }

        public void setRolSeleccionado(Rol rol)
        {
            this.rolSeleccionado = rol;
        }

        public Rol getRolSeleccionado()
        {
            return this.rolSeleccionado;
        }
        
        public Rol getRolAtIndex(int index)
        {
            return this.roles[index];
        }

    }
   
}
