using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abm_Automovil.Automovil auto = new Abm_Automovil.Automovil();
            auto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abm_Cliente.Clientes cliente = new Abm_Cliente.Clientes();
            cliente.ShowDialog();
        }
    }
}
