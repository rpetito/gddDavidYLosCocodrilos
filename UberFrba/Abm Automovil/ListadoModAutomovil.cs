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
    public partial class ListadoModAutomovil : Form
    {
        SqlConnection Conexion = BaseDeDatos.ObternerConexion();
        SqlCommand busqueda = new SqlCommand();
        SqlCommand marcas = new SqlCommand();
        SqlCommand modelos = new SqlCommand();

        public ListadoModAutomovil()
        {
            InitializeComponent();
            SqlDataReader marcasReader;
            SqlDataReader modelosReader;
            automovilesGrid.Dock = DockStyle.Fill;

            using (marcas = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_MARCAS", Conexion))
            {
                marcas.CommandType = CommandType.StoredProcedure;
            }
            marcasReader = marcas.ExecuteReader();

            while (marcasReader.Read())
            {
                marcaComboBox.Items.Add(marcasReader.GetString(1));
            }
            marcasReader.Close();



            using (modelos = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_MODELOS", Conexion))
            {
                modelos.CommandType = CommandType.StoredProcedure;
            }
            modelosReader = modelos.ExecuteReader();

            while (modelosReader.Read())
            {
                modeloComboBox.Items.Add(modelosReader.GetString(2));
            }
            modelosReader.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            marcaComboBox.ResetText();
            patenteTextBox.Clear();
            modeloComboBox.ResetText();
            choferTextBox.Clear();
            automovilesGrid.ClearSelection();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            //guardar datos de la fila seleccionada para mandarsela al formulario
            FormularioModAutomovil form = new FormularioModAutomovil();
            form.ShowDialog();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            automovilesGrid.DataSource = getAutomoviles();
        }

        private DataTable getAutomoviles()
        {
            DataTable dtAutomovil = new DataTable();

            String marca = marcaComboBox.Text;
            String modelo = modeloComboBox.Text;
            String patente = patenteTextBox.Text;
            String chofer = choferTextBox.Text;

            using (busqueda = new SqlCommand("DAVID_Y_LOS_COCODRILOS.BUSCAR_AUTOMOVILES", Conexion))
            {
                busqueda.CommandType = CommandType.StoredProcedure;
                busqueda.Parameters.Add("@marca", SqlDbType.Char);
                busqueda.Parameters["@marca"].Value = marca;
                busqueda.Parameters.Add("@modelo", SqlDbType.Char);
                busqueda.Parameters["@modelo"].Value = modelo;
                busqueda.Parameters.Add("@patente", SqlDbType.Char);
                busqueda.Parameters["@patente"].Value = patente;
                busqueda.Parameters.Add("@chofer", SqlDbType.Char);
                busqueda.Parameters["@chofer"].Value = chofer;
            }

            return dtAutomovil;
        }
    }
}
