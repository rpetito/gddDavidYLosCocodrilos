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

namespace UberFrba.Abm_Chofer
{
    public partial class ListadoBajaChofer : Form
    {
        public ListadoBajaChofer()
        {
            InitializeComponent();
            choferesGrid.Dock = DockStyle.Fill;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            dniTextBox.Clear();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            choferesGrid.DataSource = getChoferes();
        }
        private DataTable getChoferes()
        {
            DataTable dtChofer = new DataTable();
            try
            {
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                SqlCommand buscarChofer = new SqlCommand();
                SqlDataReader busqueda;


                using (buscarChofer = new SqlCommand("DAVID_Y_LOS_COCODRILOS.BUSCAR_CHOFER", Conexion))
                {
                    buscarChofer.CommandType = CommandType.StoredProcedure;
                    buscarChofer.Parameters.Add("@nombre", SqlDbType.Char);
                    buscarChofer.Parameters["@nombre"].Value = nombreTextBox.Text;
                    buscarChofer.Parameters.Add("@apellido", SqlDbType.Char);
                    buscarChofer.Parameters["@apellido"].Value = apellidoTextBox.Text;
                    buscarChofer.Parameters.Add("@dni", SqlDbType.Decimal);
                    buscarChofer.Parameters["@dni"].Value = dniTextBox.Text;
                }

                busqueda = buscarChofer.ExecuteReader();
                Conexion.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }
            return dtChofer;
        }
    }
}
