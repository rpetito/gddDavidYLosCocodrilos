using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Chofer
{
    public partial class ListadoModChofer : Form
    {
        public ListadoModChofer()
        {
            InitializeComponent();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Seleccionar";
            button.Name = "seleccionarButton";
            button.Text = "Seleccionar";
            button.UseColumnTextForButtonValue = true;
            choferesGrid.Columns.Add(button);
            button.Frozen = true;

        }

        private void choferesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			ListadoBusquedaFlowController.doFlow(e, this.choferesGrid, 3);
        }


        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            dniTextBox.Clear();
            choferesGrid.ClearSelection();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
			UsuarioData usuario = new UsuarioData();
			usuario.setNombre(this.nombreTextBox.Text);
			usuario.setApellido(this.apellidoTextBox.Text);
			usuario.setDNI(this.dniTextBox.Text);
			this.choferesGrid.DataSource = UsuarioController.buscarUsuario(usuario, 3);

        }

            
    }









}
