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
        String marca;
        String modelo;
        String patente;
        String turno;
        String chofer;
        Int32 idMarca;
        Int32 idModelo;
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
            marca = marcaComboBox.Text;
            modelo = modeloComboBox.Text;
            patente = patenteTextBox.Text;
            turno = turnoComboBox.Text;
            chofer = choferTextBox.Text;
           
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
                marcaComboBox.Items.Add(itemMarca.Value);
            } 
            idMarca = dictMarcas.FirstOrDefault(x => x.Value == marca).Key;

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
                modeloComboBox.Items.Add(itemModelo.Value);
            }
            idModelo = dictModelos.FirstOrDefault(x => x.Value == modelo).Key;
            modelosReader.Close();



            using (turnos = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_TURNOS", Conexion))
            {
                turnos.CommandType = CommandType.StoredProcedure;
            }

            turnosReader = turnos.ExecuteReader();

            while (turnosReader.Read())
            {
                turnoComboBox.Items.Add(turnosReader.GetString(3));
            }
            turnosReader.Close();
            Conexion.Close();
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

        private void crearButton_Click(object sender, EventArgs e)
        {

            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand crear = new SqlCommand();
            if (string.IsNullOrWhiteSpace(marcaComboBox.Text)
                   | string.IsNullOrWhiteSpace(modeloComboBox.Text)
                   | string.IsNullOrWhiteSpace(patenteTextBox.Text)
                   | string.IsNullOrWhiteSpace(turnoComboBox.Text)
                   | string.IsNullOrWhiteSpace(choferTextBox.Text))
            {
                MessageBox.Show("Por Favor completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (crear = new SqlCommand("DAVID_Y_LOS_COCODRILOS.AGREGAR_AUTOMOVIL", Conexion))
                    {
                        crear.CommandType = CommandType.StoredProcedure;
                        crear.Parameters.Add("@patente", SqlDbType.Char);
                        crear.Parameters["@patente"].Value = patente;
                        crear.Parameters.Add("@marca", SqlDbType.Int);
                        crear.Parameters["@marca"].Value = idMarca;
                        crear.Parameters.Add("@modelo", SqlDbType.Int);
                        crear.Parameters["@modelo"].Value = idModelo;
                        crear.Parameters.Add("@turno", SqlDbType.Char);
                        crear.Parameters["@turno"].Value = turno;
                        crear.Parameters.Add("@chofer", SqlDbType.Int);
                        crear.Parameters["@chofer"].Value = chofer;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "there was an issue!");
                }
            }
            Conexion.Close();
        }
    }
}
