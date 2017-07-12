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
    public partial class ListadoBajaAutomovil : Form
    {

        SqlCommand busqueda = new SqlCommand();
        SqlCommand marcas = new SqlCommand();
        SqlCommand modelos = new SqlCommand();


        public ListadoBajaAutomovil()
        {
            InitializeComponent();
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlDataReader marcasReader;
            SqlDataReader modelosReader;

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
            Conexion.Close();

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Eliminar";
            button.Name = "eliminarButton";
            button.Text = "Eliminar";
            button.UseColumnTextForButtonValue = true;
            automovilesGrid.Columns.Add(button);
            button.Frozen = true;

        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            marcaComboBox.ResetText();
            patenteTextBox.Clear();
            modeloComboBox.ResetText();
            choferTextBox.Clear();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            getAutomoviles();
        }

        private DataTable getAutomoviles()
        {
            DataTable dtAutomovil = new DataTable();
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand buscarAutomovil = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                using (buscarAutomovil = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_AUTOMOVILES", Conexion))
                {
                    buscarAutomovil.CommandType = CommandType.StoredProcedure;
                    buscarAutomovil.Parameters.Add("@patente", SqlDbType.Char);
                    buscarAutomovil.Parameters["@patente"].Value = patenteTextBox.Text;
                    buscarAutomovil.Parameters.Add("@marca", SqlDbType.Char);
                    buscarAutomovil.Parameters["@marca"].Value = marcaComboBox.Text;
                    buscarAutomovil.Parameters.Add("@modelo", SqlDbType.Char);
                    buscarAutomovil.Parameters["@modelo"].Value = modeloComboBox.Text;
                    buscarAutomovil.Parameters.Add("@chofer", SqlDbType.Decimal);
                    buscarAutomovil.Parameters["@chofer"].Value = choferTextBox.Text;
                    da.SelectCommand = buscarAutomovil;
                    da.Fill(dt);
                    automovilesGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }
            Conexion.Close();
            return dt;
        }

        private void automovilesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                //tirar un mensaje para confirmar si el usuario esta seguro
                //si selecciona SI
                
                String patente = (String) automovilesGrid.SelectedCells[1].Value;
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                SqlCommand eliminarAutomovil = new SqlCommand();

                try
                {
                    using (eliminarAutomovil = new SqlCommand("DAVID_Y_LOS_COCODRILOS.INHABILITAR_AUTOMOVIL", Conexion))
                    {
                        eliminarAutomovil.CommandType = CommandType.StoredProcedure;
                        eliminarAutomovil.Parameters.Add("@patente", SqlDbType.Char);
                        eliminarAutomovil.Parameters["@patente"].Value = patente;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "there was an issue!");

                }
                Conexion.Close();
            }
        }
    }
}
