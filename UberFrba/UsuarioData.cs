using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba {

	class UsuarioData {

		private String nombre;
		private String apellido;
		private String dni;
		private String mail;
		private String telefono;
		private String direccion;
		private String piso;
		private String dpto;
		private String localidad;
		private String codPos;
		private String fechaNac;
		private String username;
		private String password;
		private Int32 habilitado;


		public String getNombre() {
			return this.nombre;
		}

		public void setNombre(String nombre) {
			this.nombre = nombre;
		}

		public String getApellido() {
			return this.apellido;
		}

		public void setApellido(String apellido) {
			this.apellido = apellido;
		}

		public String getDNI() {
			return this.dni;
		}

		public void setDNI(String dni) {
			this.dni = dni;
		}

		public String getMail() {
			return this.mail;
		}

		public void setMail(String mail) {
			this.mail = mail;
		}

		public String getTelefono() {
			return this.telefono;
		}

		public void setTelefono(String telefono) {
			this.telefono = telefono;
		}

		public String getDireccion() {
			return this.direccion;
		}

		public void setDireccion(String dir) {
			this.direccion = dir;
		}

		public String getPiso() {
			return this.piso;
		}

		public void setPiso(String piso) {
			this.piso = piso;
		}

		public String getDpto() {
			return this.dpto;
		}

		public void setDpto(String depto) {
			this.dpto = depto;
		}

		public String getLocalidad() {
			return this.localidad;
		}

		public void setLocalidad(String localidad) {
			this.localidad = localidad;
		}

		public String getCodPos() { 
			return this.codPos;
		}

		public void setCodPos(String codPos) {
			this.codPos = codPos;
		}

		public String getFechaNac() {
			return this.fechaNac;
		}

		public void setFechaNac(String fechaNac) {
			this.fechaNac = fechaNac;
		}

		public String getUsername() {
			return this.username;
		}

		public void setUserName(String username) {
			this.username = username;
		}

		public String getPassword() {
			return this.password;
		}

		public void setPassword(String pass) {
			this.password = pass;
		}

		public Boolean isHabilitado() {
			return this.habilitado == 1;
		}

		public void setHabilitado(Int32 hab) {
			this.habilitado = hab;
		}

		public Int32 getHabilitadoInt() {
			return this.habilitado;
		}

		



	
	}



}
