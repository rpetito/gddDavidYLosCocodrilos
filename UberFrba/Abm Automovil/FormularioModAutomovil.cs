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
    public partial class FormularioModAutomovil : Form
    {
        public FormularioModAutomovil()
        {
            InitializeComponent();
            AutomovilSeleccionado auto = new AutomovilSeleccionado();
            marcaSelTextBox.Text = auto.getMarca();
            modeloSelTextBox.Text = auto.getModelo();
            patenteSelTextBox.Text = auto.getPatente();
            turnoSelTextBox.Text = auto.getTurno();
            choferSelTextBox.Text = auto.getChofer();
            //setear el valor del checkbox segun si esta habilitado o no
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

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarSelButton_Click(object sender, EventArgs e)
        {
            //modificar la fila de la grid con los datos cambiados en esta pantalla
        }
    }
}
