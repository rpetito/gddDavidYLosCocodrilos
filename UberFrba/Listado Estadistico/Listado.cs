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
    public partial class Listado : Form
    {
        int anioSeleccionado;
        int trimestreSeleccionado;
        int listado;
        public Listado()
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
            anioSeleccionado = 2014;
            trimestreSeleccionado = 1;
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

        private void comboBox_TipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            listado = (int)(comboBox_TipoListado.SelectedIndex + 1);
        }

        private void button_HacerConsulta_Click(object sender, EventArgs e)
        {
            if (listado == 1) {
                this.dataGridView1.DataSource = EstadisticaController.getCaso1(anioSeleccionado,trimestreSeleccionado);
            }

            if (listado == 2)
            {
                this.dataGridView1.DataSource = EstadisticaController.getCaso2(anioSeleccionado, trimestreSeleccionado);
            }

            if (listado == 3)
            {
                this.dataGridView1.DataSource = EstadisticaController.getCaso3(anioSeleccionado, trimestreSeleccionado);

            }

            if (listado == 4)
            {
                this.dataGridView1.DataSource = EstadisticaController.getCaso4(anioSeleccionado, trimestreSeleccionado);
            }

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            comboBox_TipoListado.Text = "";
            numericUpDown_Anio.ResetText();
            numericUpDown_Mes.ResetText();
        }
    }








}
