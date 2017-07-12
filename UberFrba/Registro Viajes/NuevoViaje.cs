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

namespace UberFrba.Registro_Viajes
{
    public partial class NuevoViaje : Form
    {
        SqlConnection Conexion = BaseDeDatos.ObternerConexion();
        SqlConnection Conexion2 = BaseDeDatos.ObternerConexion();
        SqlCommand obtenerAutomovil = new SqlCommand();
        SqlCommand obtenerTurnos = new SqlCommand();

        SqlDataReader resultadoAuto;
        SqlDataReader resultadoTurnos;

        public NuevoViaje()
        {
            InitializeComponent();
            this.choferTextBox.Text = UsuarioSeleccionado.getInstance().getNombre() + " " + UsuarioSeleccionado.getInstance().getNombre();

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            choferTextBox.Clear();
            automovilTextBox.Clear();
            turnoComboBox.ResetText();
            kilometrosTextBox.Clear();
            clienteTextBox.Clear();
        }

        private void choferBusquedaButton_Click(object sender, EventArgs e)
        {
            using (var chofer = new Abm_Chofer.BuscadorChoferes())
            {

                var result = chofer.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.choferTextBox.Text = UsuarioSeleccionado.getInstance().getNombre() + " " +
                                              UsuarioSeleccionado.getInstance().getApellido();

                    using (obtenerAutomovil = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_AUTOMOVILES", Conexion))
                    {
                        obtenerAutomovil.CommandType = CommandType.StoredProcedure;
                        obtenerAutomovil.Parameters.Add("@PATENTE", SqlDbType.Char);
                        obtenerAutomovil.Parameters["@PATENTE"].Value = DBNull.Value;
                        obtenerAutomovil.Parameters.Add("@MARCA", SqlDbType.Char);
                        obtenerAutomovil.Parameters["@MARCA"].Value = DBNull.Value;
                        obtenerAutomovil.Parameters.Add("@MODELO", SqlDbType.Char);
                        obtenerAutomovil.Parameters["@MODELO"].Value = DBNull.Value;
                        obtenerAutomovil.Parameters.Add("@CHOFER", SqlDbType.Decimal);
                        obtenerAutomovil.Parameters["@chofer"].Value = UsuarioSeleccionado.getInstance().getDni();
                    }
                    resultadoAuto = obtenerAutomovil.ExecuteReader();

                    while (resultadoAuto.Read())
                    {
                        automovilTextBox.Text = resultadoAuto.GetString(0);

                    }
                    Conexion.Close();

                    using (obtenerTurnos = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_TURNOS", Conexion2))
                    {
                        obtenerTurnos.CommandType = CommandType.StoredProcedure;
                    }
                    resultadoTurnos = obtenerTurnos.ExecuteReader();

                    List<Turno> turnos = new List<Turno>();

                    while (resultadoTurnos.Read())
                    {
                        Turno turno = new Turno();
                        turno.setID(resultadoTurnos.GetInt32(0));
                        turnos.Add(turno);

                    }

                    Conexion2.Close();
                    
                    foreach (Turno turnito in turnos)
                    {
                        turnoComboBox.Items.Add(Convert.ToString(turnito.getID()));
                    }



                }



            }
        }
    



        private void clienteBusquedaButton_Click_1(object sender, EventArgs e)
        {
            Abm_Cliente.BuscadorClientes cliente = new Abm_Cliente.BuscadorClientes();
            cliente.ShowDialog();
        }
    }
}
