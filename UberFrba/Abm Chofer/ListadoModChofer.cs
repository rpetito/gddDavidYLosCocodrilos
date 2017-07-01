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
    public partial class ListadoModChofer : Form
    {
        public ListadoModChofer()
        {
            InitializeComponent();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            dniTextBox.Clear();
            choferesGrid.ClearSelection();
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

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            nombreSelTextBox.Enabled = true;
            apellidoSelTextBox.Enabled = true;
            dniSelTextBox.Enabled = true;
            nacimientoSelTextBox.Enabled = true;
            telefonoSelTextBox.Enabled = true;
            direccionSelTextBox.Enabled = true;
            localidadSelTextBox.Enabled = true;
            pisoSelTextBox.Enabled = true;
            departamentoSelTextBox.Enabled = true;
            mailSelTextBox.Enabled = true;
            habilitadoCheckBox.Enabled = true;
            limpiarSelButton.Enabled = true;
            modificarSelButton.Enabled = true;
        }
    }
}
