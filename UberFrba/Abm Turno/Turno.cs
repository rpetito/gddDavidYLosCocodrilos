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

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            NuevoTurno turno = new NuevoTurno();
            turno.ShowDialog();
        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            ListadoBajaTurno bajaTurno = new ListadoBajaTurno();
            bajaTurno.ShowDialog();
        }

        private void modificacionButton_Click(object sender, EventArgs e)
        {
            ListadoModTurno modTurno = new ListadoModTurno();
            modTurno.ShowDialog();
        }
    }
}
