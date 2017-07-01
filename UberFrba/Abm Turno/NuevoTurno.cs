using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Turno
{
    public partial class NuevoTurno : Form
    {
        public NuevoTurno()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            horaInicioComboBox.ResetText();
            horaFinComboBox.ResetText();
            descripcionTextBox.Clear();
            kilometroTextBox.Clear();
            baseTextBox.Clear();
        }
    }
}
