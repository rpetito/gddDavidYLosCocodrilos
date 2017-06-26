using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Chofer
{
    public partial class NuevoChofer : Form
    {
        public NuevoChofer()
        {
            InitializeComponent();
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
            nacimientoTextBox.Clear();
            telefonoTextBox.Clear();
            direccionTextBox.Clear();
            localidadTextBox.Clear();
            pisoTextBox.Clear();
            departamentoTextBox.Clear();
            mailTextBox.Clear();
            usuarioTextBox.Clear();
            contraseniaTextBox.Clear();
            repetirTextBox.Clear();
        }
    }
}
