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
    public partial class DetalleFactura : Form
    {
        public DetalleFactura()
        {
            InitializeComponent();
            nombreLabel.Text = UsuarioSeleccionado.getInstance().getNombre() + " " + UsuarioSeleccionado.getInstance().getApellido();
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
