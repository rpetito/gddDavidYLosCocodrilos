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

namespace UberFrba.Abm_Automovil
{
    public partial class NuevoAutomovil : Form
    {
        public NuevoAutomovil()
        {
            InitializeComponent();
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand marcas = new SqlCommand();
            SqlCommand modelos = new SqlCommand();
            SqlCommand turnos = new SqlCommand();
            SqlDataReader marcasReader;
            SqlDataReader modelosReader;
            SqlDataReader turnosReader;

            using (marcas = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_MARCAS", Conexion))
            {
                marcas.CommandType = CommandType.StoredProcedure;
            }
            marcasReader = marcas.ExecuteReader();

            while (marcasReader.Read())
            {
                marcaComboBox.Items.Add(marcasReader.GetString(0));
            }
            marcasReader.Close();



            using (modelos = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_MODELOS", Conexion))
            {
                modelos.CommandType = CommandType.StoredProcedure;
            }
            modelosReader = modelos.ExecuteReader();

            while (modelosReader.Read())
            {
                modeloComboBox.Items.Add(modelosReader.GetString(0));
            }
            modelosReader.Close();



            using (turnos = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_TURNOS", Conexion))
            {
                turnos.CommandType = CommandType.StoredProcedure;
            }

            turnosReader = turnos.ExecuteReader();

            while (turnosReader.Read())
            {
                turnoComboBox.Items.Add(turnosReader.GetString(0));
            }
            turnosReader.Close();

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            marcaComboBox.ResetText();
            modeloComboBox.ResetText();
            patenteTextBox.Clear();
            turnoComboBox.ResetText();
            choferTextBox.Clear();
        }
    }
}
