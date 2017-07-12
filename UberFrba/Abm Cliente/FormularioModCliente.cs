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
	public partial class FormularioModCliente : Form {
		public FormularioModCliente() {
			InitializeComponent();
			nombreSelTextBox.Text = UsuarioSeleccionado.getInstance().getNombre();
			apellidoSelTextBox.Text = UsuarioSeleccionado.getInstance().getApellido();
			dniSelTextBox.Text = UsuarioSeleccionado.getInstance().getDni().ToString();
			mailSelTextBox.Text = UsuarioSeleccionado.getInstance().getMail();
			telefonoSelTextBox.Text = UsuarioSeleccionado.getInstance().getTelefono();
			direccionSelTextBox.Text = UsuarioSeleccionado.getInstance().getDireccion();
			pisoSelTextBox.Text = UsuarioSeleccionado.getInstance().getPiso().ToString();
			departamentoSelTextBox.Text = UsuarioSeleccionado.getInstance().getDepartamento();
			localidadSelTextBox.Text = UsuarioSeleccionado.getInstance().getLocalidad();
			fechaNacimientoSelDatePicker.Text = UsuarioSeleccionado.getInstance().getFechaNacimiento().ToString();
			if( UsuarioSeleccionado.getInstance().getHabilitado() == 1 )
				habilitadoCheckBox.Checked = true;
			else
				habilitadoCheckBox.Checked = false;

			UsuarioSeleccionado.setInstance();
		}

		private void cancelarButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void limpiarSelButton_Click(object sender, EventArgs e) {
			nombreSelTextBox.Clear();
			apellidoSelTextBox.Clear();
			dniSelTextBox.Clear();
			fechaNacimientoSelDatePicker.ResetText();
			telefonoSelTextBox.Clear();
			direccionSelTextBox.Clear();
			localidadSelTextBox.Clear();
			pisoSelTextBox.Clear();
			departamentoSelTextBox.Clear();
			codigoSelTextBox.Clear();
			mailSelTextBox.Clear();
			habilitadoCheckBox.Checked = false;
		}

		private void modificarSelButton_Click(object sender, EventArgs e) {
			SqlConnection Conexion = BaseDeDatos.ObternerConexion();
			SqlCommand modificarCliente = new SqlCommand();

			if( string.IsNullOrWhiteSpace(nombreSelTextBox.Text)
					| string.IsNullOrWhiteSpace(apellidoSelTextBox.Text)
					| string.IsNullOrWhiteSpace(fechaNacimientoSelDatePicker.Text)
					| string.IsNullOrWhiteSpace(telefonoSelTextBox.Text)
					| string.IsNullOrWhiteSpace(direccionSelTextBox.Text)
					| string.IsNullOrWhiteSpace(pisoSelTextBox.Text)
					| string.IsNullOrWhiteSpace(departamentoSelTextBox.Text)
					| string.IsNullOrWhiteSpace(localidadSelTextBox.Text)
					| string.IsNullOrWhiteSpace(mailSelTextBox.Text)
					| string.IsNullOrWhiteSpace(codigoSelTextBox.Text) ) {
				MessageBox.Show("Por Favor completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {

				UsuarioData usuario = new UsuarioData();
				usuario.setNombre(this.nombreSelTextBox.Text);
				usuario.setApellido(this.apellidoSelTextBox.Text);
				usuario.setDNI(this.dniSelTextBox.Text);
				usuario.setMail(this.mailSelTextBox.Text);
				usuario.setTelefono(this.telefonoSelTextBox.Text);
				usuario.setDireccion(this.direccionSelTextBox.Text);
				usuario.setPiso(this.pisoSelTextBox.Text);
				usuario.setDpto(this.departamentoSelTextBox.Text);
				usuario.setLocalidad(this.localidadSelTextBox.Text);
				usuario.setCodPos("");
				usuario.setFechaNac(this.fechaNacimientoSelDatePicker.Value.ToShortDateString());
				usuario.setHabilitado(this.habilitadoCheckBox.Checked ? 1 : 0);

				UsuarioController.altaOModificarUsuario(usuario, 2, "MODIFICAR_USUARIO");
			
			
			}



		}


	}






}
