using System;
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
    public partial class Rol : Form
    {
        public Rol()
        {
            InitializeComponent();
        }

        private void nuevoButton_Click(object sender, EventArgs e)
        {
            NuevoRol rol = new NuevoRol();
            rol.ShowDialog();
        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            ListadoBajaRol bajaRol = new ListadoBajaRol();
            bajaRol.ShowDialog();
        }

        private void modificacionButton_Click(object sender, EventArgs e)
        {
            ListadoModRol modRol = new ListadoModRol();
            modRol.ShowDialog();
        }
    }
}
