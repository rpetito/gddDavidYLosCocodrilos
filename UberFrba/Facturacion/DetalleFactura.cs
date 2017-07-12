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
    public partial class DetalleFactura : Form
    {
        String fecha = ConfigurationSettings.AppSettings["DateKey"];
        public DetalleFactura()
        {
            InitializeComponent();
            nombreLabel.Text = UsuarioSeleccionado.getInstance().getNombre() + " " + UsuarioSeleccionado.getInstance().getApellido();
            
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand detallarFactura = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                using (detallarFactura = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_FACTURAS", Conexion))
                {
                    detallarFactura.CommandType = CommandType.StoredProcedure;
                    detallarFactura.Parameters.Add("@fecha", SqlDbType.DateTime);
                    detallarFactura.Parameters["@fecha"].Value = DateTime.Parse(fecha);
                    detallarFactura.Parameters.Add("@cliente", SqlDbType.Decimal);
                    detallarFactura.Parameters["@cliente"].Value = UsuarioSeleccionado.getInstance().getDni();

                    da.SelectCommand = detallarFactura;
                    da.Fill(dt);
                    detallesGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");
            }
            Conexion.Close();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
