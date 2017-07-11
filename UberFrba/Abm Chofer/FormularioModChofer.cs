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
    public partial class FormularioModChofer : Form
    {
        public FormularioModChofer()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarSelButton_Click(object sender, EventArgs e)
        {
            nombreSelTextBox.Clear();
            apellidoSelTextBox.Clear();
            dniSelTextBox.Clear();
            nacimientoSelTextBox.Clear();
            telefonoSelTextBox.Clear();
            direccionSelTextBox.Clear();
            localidadSelTextBox.Clear();
            pisoSelTextBox.Clear();
            departamentoSelTextBox.Clear();
            mailSelTextBox.Clear();
            habilitadoCheckBox.Checked = false;
        }
    }
}
