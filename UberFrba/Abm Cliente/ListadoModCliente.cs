﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Cliente
{
    public partial class ListadoModCliente : Form
    {
        public ListadoModCliente()
        {
            InitializeComponent();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Seleccionar";
            button.Name = "seleccionarButton";
            button.Text = "Seleccionar";
            button.UseColumnTextForButtonValue = true;
            clientesGrid.Columns.Add(button);
            button.Frozen = true;
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            dniTextBox.Clear();
            clientesGrid.ClearSelection();
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
			this.clientesGrid.DataSource = UsuarioController.buscarUsuario(usuario, 2);
        }


        private void clientesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			ListadoBusquedaFlowController.doFlow(e, this.clientesGrid, 2);
        }


    }
}
