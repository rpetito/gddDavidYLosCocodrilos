using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Facturacion
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void busquedaCliente_Click(object sender, EventArgs e)
        {
            Abm_Cliente.BuscadorClientes cliente = new Abm_Cliente.BuscadorClientes();
            cliente.ShowDialog();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            anioTextBox.Clear();
            mesComboBox.ResetText();
            clienteTextBox.Clear();
            viajesGrid.ClearSelection();
            totalTextBox.Clear();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
