using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol {


	public partial class RemoverFuncionalidadARol : Form {

		public Rol rol;
		public Functionality selectedFunctionality = new Functionality();

		public RemoverFuncionalidadARol(Rol rol) {
			InitializeComponent();
			this.rol = rol;
			fillGridData();
		}


		private void fillGridData() {
			this.dataGridView1.DataSource = FunctionalityController.getAllFunctionalitiesForRol(rol.getID());
		}

		
		
		private void remover_Click(object sender, EventArgs e) {
			if( this.dataGridView1.SelectedCells.Count == 2 ) {
				DataGridViewRow selectedRow = this.dataGridView1.SelectedRows[0];
				selectedFunctionality.setID((Int32) selectedRow.Cells[0].Value);
				selectedFunctionality.setDetalle((String) selectedRow.Cells[1].Value);
				this.DialogResult = DialogResult.OK;
				this.Close();
			} else {
				MessageBox.Show("Debe seleccionar la fila completa de una funcionalidad y sólo una");
			}
			
		}



		private void cancelar_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}



	}







}
