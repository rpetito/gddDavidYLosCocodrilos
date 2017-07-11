using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UberFrba.Listado_Estadistico
{
    public partial class Form1 : Form
    {
        int anioSeleccionado;
        int trimestreSeleccionado;
        int listado;
        public Form1()
        {
            InitializeComponent();
            comboBox_TipoListado.Items.Add("Choferes con mayor recaudacion");
            comboBox_TipoListado.Items.Add("Choferes con el viaje más largo realizado");
            comboBox_TipoListado.Items.Add("Clientes con mayor consumo");
            comboBox_TipoListado.Items.Add("Cliente que utilizo más veces el mismo automóvil en los viajes que ha realizado");

        }

        private void numericUpDown_Anio_ValueChanged(object sender, EventArgs e)
        {
            anioSeleccionado = (int)numericUpDown_Anio.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anioSeleccionado = 0;
            trimestreSeleccionado = 0;
            listado = -1;
        }

        private void numericUpDown_Mes_ValueChanged(object sender, EventArgs e)
        {
            trimestreSeleccionado = (int)numericUpDown_Mes.Value;
        }

        private void button_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
