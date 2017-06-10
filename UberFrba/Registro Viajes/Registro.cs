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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoViajes listadoViajes = new ListadoViajes();
            listadoViajes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NuevoViaje nuevoViaje = new NuevoViaje();
            nuevoViaje.ShowDialog();
        }
    }
}
