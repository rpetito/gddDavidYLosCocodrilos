using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Registro_Viajes
{
    public partial class NuevoViaje : Form
    {
        public NuevoViaje()
        {
            InitializeComponent();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            choferTextBox.Clear();
            automovilTextBox.Clear();
            turnoComboBox.ResetText();
            kilometrosTextBox.Clear();
            horaInicioComboBox.ResetText();
            horaFinComboBox.ResetText();
            clienteTextBox.Clear();
        }

        private void choferBusquedaButton_Click(object sender, EventArgs e)
        {
            Abm_Chofer.BuscadorChoferes chofer = new Abm_Chofer.BuscadorChoferes();
            chofer.ShowDialog();
        }

        private void clienteBusquedaButton_Click(object sender, EventArgs e)
        {
            Abm_Cliente.BuscadorClientes cliente = new Abm_Cliente.BuscadorClientes();
            cliente.ShowDialog();
        }
    }
}
