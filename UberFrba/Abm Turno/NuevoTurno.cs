using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UberFrba.Abm_Turno {
	public partial class NuevoTurno : Form {
		public NuevoTurno() {
			InitializeComponent();
		}

		private void cancelarButton_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void limpiarButton_Click(object sender, EventArgs e) {
			horaInicioTextBox.Clear();
			horaFin.Clear();
			descripcionTextBox.Clear();
			kilometroTextBox.Clear();
			baseTextBox.Clear();
		}


		private void crearButton_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(horaInicioTextBox.Text)
					| string.IsNullOrWhiteSpace(horaFin.Text)
					| string.IsNullOrWhiteSpace(descripcionTextBox.Text)
					| string.IsNullOrWhiteSpace(kilometroTextBox.Text)
					| string.IsNullOrWhiteSpace(baseTextBox.Text)) {
				MessageBox.Show("Por Favor completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			} else {
				try {
					SqlConnection Conexion = BaseDeDatos.ObternerConexion();
					MessageBox.Show("estamos conectados");
					SqlCommand nuevoTurno = new SqlCommand();
					SqlDataReader result;


					using (nuevoTurno = new SqlCommand("DAVID_Y_LOS_COCODRILOS.AGREGAR_TURNO", Conexion)) {
						/*nuevoTurno.CommandType = CommandType.StoredProcedure;
						nuevoTurno.Parameters.Add("@horaInicio", SqlDbType.Char);
						nuevoTurno.Parameters["@username"].Value = pUsername;
						nuevoTurno.Parameters.Add("@password", SqlDbType.Char);
						nuevoTurno.Parameters["@password"].Value = pContrasenia;
						nuevoTurno.Parameters.Add("@password", SqlDbType.Char);
						nuevoTurno.Parameters["@password"].Value = pContrasenia;
						nuevoTurno.Parameters.Add("@password", SqlDbType.Char);
						nuevoTurno.Parameters["@password"].Value = pContrasenia;
						nuevoTurno.Parameters.Add("@password", SqlDbType.Char);
						nuevoTurno.Parameters["@password"].Value = pContrasenia;
						 * */
					}

					result = nuevoTurno.ExecuteReader();
					if (result.Read()) {

					}
				}
				catch {
					
				}
				
			}
			
		}
		
	}
	
}

 

