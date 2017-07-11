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
        decimal horaInicioVar;
        decimal horaFinVar;
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
                horaFinVar = Convert.ToDecimal(horaFin.Text);
                horaInicioVar = Convert.ToDecimal(horaInicioTextBox.Text);
                if (horaFinVar - horaInicioVar < 24)
                {
                    try
                    {
                        SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                        MessageBox.Show("estamos conectados");
                        SqlCommand nuevoTurno = new SqlCommand();
                        SqlDataReader result;
                        
                        using (nuevoTurno = new SqlCommand("DAVID_Y_LOS_COCODRILOS.AGREGAR_TURNO", Conexion))
                        {
                            nuevoTurno.CommandType = CommandType.StoredProcedure;
                            nuevoTurno.Parameters.Add("@HORA_INICIO", SqlDbType.Decimal);
                            nuevoTurno.Parameters["@HORA_INICIO"].Value = horaInicioTextBox.Text;
                            nuevoTurno.Parameters.Add("@HORA_FIN", SqlDbType.Decimal);
                            nuevoTurno.Parameters["@HORA_FIN"].Value = horaFin.Text;
                            nuevoTurno.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar);
                            nuevoTurno.Parameters["@DESCRIPCION"].Value = descripcionTextBox.Text;
                            nuevoTurno.Parameters.Add("@VALOR_KILOMETRO", SqlDbType.Decimal);
                            nuevoTurno.Parameters["@VALOR_KILOMETRO"].Value = kilometroTextBox.Text;
                            nuevoTurno.Parameters.Add("@PRECIO_BASE", SqlDbType.Decimal);
                            nuevoTurno.Parameters["@PRECIO_BASE"].Value = baseTextBox.Text;

                        }

                        result = nuevoTurno.ExecuteReader();
                        if (result.Read())
                        {
                            if (result.GetInt32(0) > 0)
                            {
                                MessageBox.Show("Error al generar un nuevo turno. Este turno ya existe.");
                            }
                            else
                            {
                                MessageBox.Show("Nuevo turno generado");
                            }
                        }
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Un turno no puede durar mas de 24 horas, intenta de nuevo.");
                }
                
            

            }
			
			
		}
		
	}
	
}

 

