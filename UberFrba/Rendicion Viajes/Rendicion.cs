using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Rendicion_Viajes
{
    public partial class Rendicion : Form
    {
        public Rendicion()
        {
            InitializeComponent();
        }

        private void busquedaChoferButton_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BuscadorChoferes chofer = new Abm_Chofer.BuscadorChoferes();
            chofer.ShowDialog();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            fechaTimePicker.ResetText();
            choferTextBox.Clear();
            turnoComboBox.ResetText();
            viajesGrid.ClearSelection();
            totalTextBox.Clear();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
