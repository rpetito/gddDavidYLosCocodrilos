﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Facturacion
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.ShowDialog();
        }
    }
}
