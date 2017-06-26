using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            NuevoCliente cliente = new NuevoCliente();
            cliente.ShowDialog();
        }

        private void modificacionButton_Click(object sender, EventArgs e)
        {
            ListadoModCliente modCliente = new ListadoModCliente();
            modCliente.ShowDialog();
        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            ListadoBajaCliente bajaCliente = new ListadoBajaCliente();
            bajaCliente.ShowDialog();
        }
    }
}
