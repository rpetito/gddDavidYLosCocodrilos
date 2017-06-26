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
    public partial class Automovil : Form
    {
        public Automovil()
        {
            InitializeComponent();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            NuevoAutomovil nuevoAuto = new NuevoAutomovil();
            nuevoAuto.ShowDialog();
        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            ListadoBajaAutomovil listaBaja = new ListadoBajaAutomovil();
            listaBaja.ShowDialog();

        }

        private void modificacionButton_Click(object sender, EventArgs e)
        {
            ListadoModAutomovil listaMod = new ListadoModAutomovil();
            listaMod.ShowDialog();
        }
    }
}
