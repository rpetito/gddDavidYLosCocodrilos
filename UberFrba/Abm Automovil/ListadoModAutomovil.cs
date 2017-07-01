using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Automovil
{
    public partial class ListadoModAutomovil : Form
    {
        public ListadoModAutomovil()
        {
            InitializeComponent();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            marcaComboBox.ResetText();
            patenteTextBox.Clear();
            modeloTextBox.Clear();
            choferTextBox.Clear();
            automovilesGrid.ClearSelection();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarSelButton_Click(object sender, EventArgs e)
        {
            marcaSelTextBox.Clear();
            modeloSelTextBox.Clear();
            patenteSelTextBox.Clear();
            turnoSelTextBox.ResetText();
            choferSelTextBox.Clear();
            habilitadoCheckBox.Checked = false;
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            marcaSelTextBox.Enabled = true;
            modeloSelTextBox.Enabled = true;
            patenteSelTextBox.Enabled = true;
            turnoSelTextBox.Enabled = true;
            choferSelTextBox.Enabled = true;
            habilitadoCheckBox.Enabled = true;
            limpiarSelButton.Enabled = true;
            modificarSelButton.Enabled = true;
        }
    }
}
