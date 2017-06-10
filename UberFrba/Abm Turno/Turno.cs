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
    public partial class Turno : Form
    {
        public Turno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoTurno turno = new NuevoTurno();
            turno.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoBajaTurno bajaTurno = new ListadoBajaTurno();
            bajaTurno.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListadoModTurno modTurno = new ListadoModTurno();
            modTurno.ShowDialog();
        }
    }
}
