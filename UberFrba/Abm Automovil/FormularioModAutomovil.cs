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

namespace UberFrba.Abm_Automovil
{
    public partial class FormularioModAutomovil : Form
    {
        public FormularioModAutomovil()
        {
            InitializeComponent();
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand marcas = new SqlCommand();
            SqlCommand modelos = new SqlCommand();
            SqlCommand turnos = new SqlCommand();
            SqlDataReader marcasReader;
            SqlDataReader modelosReader;
            SqlDataReader turnosReader;
            Int32 idMarca;
            Int32 idModelo;

            var dictMarcas = new Dictionary<int, String>();
            var dictModelos = new Dictionary<int, String>();

            using (marcas = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_MARCAS", Conexion))
            {
                marcas.CommandType = CommandType.StoredProcedure;
            }
            marcasReader = marcas.ExecuteReader();

            while (marcasReader.Read())
            {
                dictMarcas.Add(marcasReader.GetInt32(0), (marcasReader.GetString(1)));
            }

            foreach (KeyValuePair<Int32, String> itemMarca in dictMarcas)
            {
                marcaSelComboBox.Items.Add(itemMarca.Value);
            }
            idMarca = dictMarcas.FirstOrDefault(x => x.Value == marcaSelComboBox.Text).Key;

            marcasReader.Close();



            using (modelos = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_MODELOS", Conexion))
            {
                modelos.CommandType = CommandType.StoredProcedure;
            }
            modelosReader = modelos.ExecuteReader();

            while (modelosReader.Read())
            {
                dictModelos.Add(modelosReader.GetInt32(0), (modelosReader.GetString(2)));
            }

            foreach (KeyValuePair<Int32, String> itemModelo in dictModelos)
            {
                modeloSelComboBox.Items.Add(itemModelo.Value);
            }
            idModelo = dictModelos.FirstOrDefault(x => x.Value == modeloSelComboBox.Text).Key;
            modelosReader.Close();



            using (turnos = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_TURNOS", Conexion))
            {
                turnos.CommandType = CommandType.StoredProcedure;
            }

            turnosReader = turnos.ExecuteReader();

            while (turnosReader.Read())
            {
                turnoSelComboBox.Items.Add(turnosReader.GetString(3));
            }
            turnosReader.Close();
            Conexion.Close();

            marcaSelComboBox.Text = AutomovilSeleccionado.getInstance().getMarca().ToString();
            modeloSelComboBox.Text = AutomovilSeleccionado.getInstance().getModelo().ToString();
            patenteSelTextBox.Text = AutomovilSeleccionado.getInstance().getPatente();
            turnoSelComboBox.Text = AutomovilSeleccionado.getInstance().getTurno().ToString();
            choferSelTextBox.Text = AutomovilSeleccionado.getInstance().getChofer().ToString();
            if (AutomovilSeleccionado.getInstance().getHabilitado() == 1)
                habilitadoCheckBox.Checked = true;
            else habilitadoCheckBox.Checked = false;

            AutomovilSeleccionado.setInstance();
        }

        private void limpiarSelButton_Click(object sender, EventArgs e)
        {
            marcaSelComboBox.ResetText();
            modeloSelComboBox.ResetText();
            patenteSelTextBox.Clear();
            turnoSelComboBox.ResetText();
            choferSelTextBox.Clear();
            habilitadoCheckBox.Checked = false;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarSelButton_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand modificarAutomovil = new SqlCommand();

            if (string.IsNullOrWhiteSpace(patenteSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(marcaSelComboBox.Text)
                    | string.IsNullOrWhiteSpace(modeloSelComboBox.Text)
                    | string.IsNullOrWhiteSpace(turnoSelComboBox.Text)
                    | string.IsNullOrWhiteSpace(choferSelTextBox.Text))
            {
                MessageBox.Show("Por Favor completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int habilitado;
                    if (habilitadoCheckBox.Checked)
                        habilitado = 1;
                    else habilitado = 0;

                    Int32 selectedMarca = marcaSelComboBox.SelectedIndex;// creo que esta mal
                    Int32 selectedModelo = modeloSelComboBox.SelectedIndex;// creo que esta mal

                    using (modificarAutomovil = new SqlCommand("DAVID_Y_LOS_COCODRILOS.MODIFICAR_AUTOMOVIL", Conexion))
                    {
                        modificarAutomovil.CommandType = CommandType.StoredProcedure;
                        modificarAutomovil.Parameters.Add("@patente", SqlDbType.Char);
                        modificarAutomovil.Parameters["@patente"].Value = patenteSelTextBox.Text;
                        modificarAutomovil.Parameters.Add("@marca", SqlDbType.Int);
                        modificarAutomovil.Parameters["@marca"].Value = selectedMarca;
                        modificarAutomovil.Parameters.Add("@modelo", SqlDbType.Int);
                        modificarAutomovil.Parameters["@modelo"].Value = selectedModelo;
                        modificarAutomovil.Parameters.Add("@chofer", SqlDbType.Decimal);
                        modificarAutomovil.Parameters["@chofer"].Value = choferSelTextBox.Text;
                        modificarAutomovil.Parameters.Add("@habilitado", SqlDbType.Bit);
                        modificarAutomovil.Parameters["@habilitado"].Value = habilitado;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "there was an issue!");
                }
            }
            Conexion.Close();
            this.Close();
        }
    }
}
