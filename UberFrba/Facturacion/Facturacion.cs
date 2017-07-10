using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Facturacion()
        {
            InitializeComponent();
            
            var fecha = ConfigurationSettings.AppSettings["DateKey"];
            var appDate = DateTime.Parse(fecha);
            anioLabel.Text = appDate.Month.ToString();
            mesLabel.Text = appDate.Year.ToString();
        }

        private void busquedaCliente_Click(object sender, EventArgs e)
        {
            Abm_Cliente.BuscadorClientes cliente = new Abm_Cliente.BuscadorClientes();
            cliente.ShowDialog();
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
