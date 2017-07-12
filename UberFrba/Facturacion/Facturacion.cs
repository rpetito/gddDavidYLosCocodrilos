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
using System.Configuration;

namespace UberFrba.Facturacion
{
    public partial class Facturacion : Form
    {
        String fecha = ConfigurationSettings.AppSettings["DateKey"];
        
        public Facturacion()
        {
            InitializeComponent();
            DateTime appDate = DateTime.Parse(fecha);
            mesLabel.Text = appDate.Month.ToString();
            anioLabel.Text = appDate.Year.ToString();
        }

        private void busquedaCliente_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionado.setInstance();
            Abm_Cliente.BuscadorClientes cliente = new Abm_Cliente.BuscadorClientes();
            cliente.ShowDialog();
            clienteTextBox.Text = UsuarioSeleccionado.getInstance().getNombre() + " " + UsuarioSeleccionado.getInstance().getApellido();

            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand facturar = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            using (facturar = new SqlCommand("DAVID_Y_LOS_COCODRILOS.BUSCAR_USUARIO", Conexion))
            {
                facturar.CommandType = CommandType.StoredProcedure;
                facturar.Parameters.Add("@cliente", SqlDbType.Decimal);
                facturar.Parameters["@cliente"].Value = UsuarioSeleccionado.getInstance().getDni();
                facturar.Parameters.Add("@fecha", SqlDbType.Date);
                facturar.Parameters["@fecha"].Value = DateTime.Parse(fecha);
                da.SelectCommand = facturar;
                da.Fill(dt);
                viajesGrid.DataSource = dt;
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            clienteTextBox.Clear();
            viajesGrid.ClearSelection();
            totalTextBox.Clear();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facturarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
