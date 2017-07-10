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

namespace UberFrba
{
    public partial class SeleccionRol : Form
    {
        public SeleccionRol()
        {
            InitializeComponent();
            foreach(Rol r in Usuario.getInstance().getRoles()) {
                rolComboBox.Items.Add(r.getDetalle());
            }
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            Rol selectedRol = Usuario.getInstance().getRolAtIndex(rolComboBox.SelectedIndex);
            Usuario.getInstance().setRolSeleccionado(selectedRol);

            Menu menu = new Menu();
            menu.ShowDialog();
        }
    }
}
