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
    public partial class ListadoBajaTurno : Form
    {
        public ListadoBajaTurno()
        {
            InitializeComponent();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            descripcionTextBox.Clear();
            turnosGrid.ClearSelection();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
