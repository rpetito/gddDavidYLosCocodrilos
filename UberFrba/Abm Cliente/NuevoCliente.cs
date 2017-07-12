using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente {
	public partial class NuevoCliente : Form {
		public NuevoCliente() {
			InitializeComponent();
		}

		private void cancelarButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void limpiarButton_Click(object sender, EventArgs e) {
			nombreTextBox.Clear();
			apellidoTextBox.Clear();
			dniTextBox.Clear();
			nacimientoDatePicker.ResetText();
			telefonoTextBox.Clear();
			direccionTextBox.Clear();
			localidadTextBox.Clear();
			pisoTextBox.Clear();
			departamentoTextBox.Clear();
			codigoTextBox.Clear();
			mailTextBox.Clear();
			usuarioTextBox.Clear();
			contraseniaTextBox.Clear();
			repetirTextBox.Clear();
		}

		private void crearButton_Click(object sender, EventArgs e) {
			SqlConnection Conexion = BaseDeDatos.ObternerConexion();
			SqlCommand crearCliente = new SqlCommand();

			if( string.IsNullOrWhiteSpace(nombreTextBox.Text)
					| string.IsNullOrWhiteSpace(apellidoTextBox.Text)
					| string.IsNullOrWhiteSpace(dniTextBox.Text)
					| string.IsNullOrWhiteSpace(nacimientoDatePicker.Text)
					| string.IsNullOrWhiteSpace(telefonoTextBox.Text)
					| string.IsNullOrWhiteSpace(direccionTextBox.Text)
					| string.IsNullOrWhiteSpace(localidadTextBox.Text)
					| string.IsNullOrWhiteSpace(pisoTextBox.Text)
					| string.IsNullOrWhiteSpace(departamentoTextBox.Text)
					| string.IsNullOrWhiteSpace(codigoTextBox.Text)
					| string.IsNullOrWhiteSpace(mailTextBox.Text)
					| string.IsNullOrWhiteSpace(usuarioTextBox.Text)
					| string.IsNullOrWhiteSpace(contraseniaTextBox.Text)
					| string.IsNullOrWhiteSpace(repetirTextBox.Text) ) {
				MessageBox.Show("Por Favor completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if( contraseniaTextBox.Text != repetirTextBox.Text ) {
				contraseniaTextBox.ResetText();
				repetirTextBox.ResetText();
				MessageBox.Show("No coinciden las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				UsuarioData usuario = new UsuarioData();
				usuario.setNombre(this.nombreTextBox.Text);
				usuario.setApellido(this.apellidoTextBox.Text);
				usuario.setDNI(this.dniTextBox.Text);
				usuario.setMail(this.mailTextBox.Text);
				usuario.setTelefono(this.telefonoTextBox.Text);
				usuario.setDireccion(this.direccionTextBox.Text);
				usuario.setPiso(this.pisoTextBox.Text);
				usuario.setDpto(this.departamentoTextBox.Text);
				usuario.setLocalidad(this.localidadTextBox.Text);
				usuario.setCodPos("");
				usuario.setFechaNac(this.nacimientoDatePicker.Value.ToShortDateString());
				usuario.setUserName(this.usuarioTextBox.Text);
				usuario.setPassword(this.contraseniaTextBox.Text);

				UsuarioController.altaOModificarUsuario(usuario, 2, "ALTA_USUARIO");
			}

		}





	}





}