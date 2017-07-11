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
    public partial class ListadoBajaRol : Form
    {



        public ListadoBajaRol()
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


		private void buscarButton_Click(object sender, EventArgs e) {
			this.rolesGrid.DataSource = RolController.findAvailableRol(this.nombreTextBox.Text);
		}

		private void eliminarButton_Click(object sender, EventArgs e) {
			if( rolesGrid.SelectedCells.Count == 3 ) {
				Int32 selectedRol = (Int32) rolesGrid.SelectedCells[0].Value;
				RolController.removeRol(selectedRol);
			}
			
		}






    }










}
