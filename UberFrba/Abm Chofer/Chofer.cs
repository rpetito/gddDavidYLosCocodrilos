using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Chofer
{
    public partial class Chofer : Form
    {
        public Chofer()
        {
            InitializeComponent();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            NuevoChofer chofer = new NuevoChofer();
            chofer.ShowDialog();
        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            ListadoBajaChofer bajaChofer = new ListadoBajaChofer();
            bajaChofer.ShowDialog();
        }

        private void modificacionButton_Click(object sender, EventArgs e)
        {
            ListadoModChofer modChofer = new ListadoModChofer();
            modChofer.ShowDialog();
        }
    }
}
