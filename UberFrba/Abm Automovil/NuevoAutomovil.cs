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
    public partial class NuevoAutomovil : Form
    {
        public NuevoAutomovil()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            marcaTextBox.Clear();
            modeloTextBox.Clear();
            patenteTextBox.Clear();
            turnoComboBox.ResetText();
            choferTextBox.Clear();
        }
    }
}
