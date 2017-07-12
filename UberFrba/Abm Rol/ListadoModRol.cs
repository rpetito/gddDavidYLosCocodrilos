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
			if( rolesGrid.SelectedCells.Count == 3 ) {
				using( var form = new FormularioModRol(getSelectedRol(rolesGrid.SelectedCells)) ) {
					
					var result = form.ShowDialog();

					if( result == DialogResult.OK ) {
						this.rolesGrid.DataSource = this.rolesGrid.DataSource = RolController.findAllRol(this.nombreTextBox.Text);
					}

				}
			} else { 
				MessageBox.Show("Debe seleccionar al menos un rol y sólo uno.");
			}
        }

		private void buscarButton_Click(object sender, EventArgs e) {
			this.rolesGrid.DataSource = RolController.findAllRol(this.nombreTextBox.Text);
		}


		private Rol getSelectedRol(DataGridViewSelectedCellCollection selectedCells) {

			 Rol selectedRol = new Rol();

			selectedRol.setID((Int32) selectedCells[0].Value);
			selectedRol.setDetalle((String) selectedCells[1].Value);
			selectedRol.setHabilitado((Int32) selectedCells[2].Value);

			return selectedRol;
			
		}

		





    }






}
