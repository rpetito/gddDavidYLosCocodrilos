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
    public partial class FormularioModTurno : Form
    {
        public FormularioModTurno()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarSelButton_Click(object sender, EventArgs e)
        {
            horaInicioSelComboBox.ResetText();
            horaFinSelComboBox.ResetText();
            descripcionSelTextBox.Clear();
            kilometroSelTextBox.Clear();
            baseSelTextBox.Clear();
            habilitadoCheckBox.Checked = false;
        }
    }
}
