﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol
{
    public partial class ListadoModRol : Form
    {
        public ListadoModRol()
        {
            InitializeComponent();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            rolesGrid.ClearSelection();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            //mandar seleccion al form
            FormularioModRol form = new FormularioModRol();
            form.ShowDialog();
        }
    }
}
