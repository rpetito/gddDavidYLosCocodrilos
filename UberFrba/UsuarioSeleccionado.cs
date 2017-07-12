using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class UsuarioSeleccionado
    {
        public static UsuarioSeleccionado instance = null;
        private String nombre;
        private String apellido;
        private Decimal dni;
        private String mail;
        private String telefono;
        private String direccion;
        private Int32 piso;
        private String departamento;
        private String localidad;
        private String codigoPostal;
        private DateTime fechaNacimiento;
        private String username;
        private String password;
        private Int32 habilitado;

        public static UsuarioSeleccionado getInstance()
        {
            if (instance == null)
            {
                instance = new UsuarioSeleccionado();
            }

            return instance;
        }

        public static void setInstance() {
            instance = null;
        }

        public String getNombre() {
            return nombre;
        }

        public void setNombre(String nombre) {
            this.nombre = nombre;
        }

        public String getApellido() {
            return apellido;
        }

        public void setApellido(String apellido) {
            this.apellido = apellido;
        }

        public Decimal getDni() {
            return dni;
        }

        public void setDni(Decimal dni) {
            this.dni = dni;
        }

        public String getMail() {
            return mail;
        }

        public void setMail(String mail) {
            this.mail = mail;
        }

        public String getTelefono()
        {
            return telefono;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public String getDireccion()
        {
            return direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public Int32 getPiso()
        {
            return piso;
        }

        public void setPiso(Int32 piso)
        {
            this.piso = piso;
        }

        public String getDepartamento()
        {
            return departamento;
        }

        public void setDepartamento(String departamento)
        {
            this.departamento = departamento;
        }

        public void setLocalidad(String localidad)
        {
            this.localidad = localidad;
        }

        public String getLocalidad()
        {
            return localidad;
        }

        public void setCodigoPostal(String codigoPostal)
        {
            this.codigoPostal = codigoPostal;
        }

        public String getCodigoPostal()
        {
            return codigoPostal;
        }

        public void setFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public DateTime getFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        public String getUsername()
        {
            return username;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getPassword() {
            return password;
        }

        public void setHabilitado(Int32 habilitado) {
            this.habilitado = habilitado;
        }

        public Int32 getHabilitado() {
            return habilitado;
        }


    }
}
