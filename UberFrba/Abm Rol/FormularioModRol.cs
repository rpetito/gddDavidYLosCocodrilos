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
    public partial class FormularioModRol : Form
    {

		public Rol rol;
		private String functionalityAction;
		private Functionality selectedFunctionality = new Functionality();



        public FormularioModRol(Rol rol) {
            InitializeComponent();
			this.functionalityText.Visible = false;
			this.rol = rol;
			this.habilitadoCheckBox.Checked = this.rol.getHabilitado();
//			fillFunctionalitiesTable();
        }



        private void cancelarButton_Click(object sender, EventArgs e)
		{
			this.Close();
        }



        private void limpiarSelButton_Click(object sender, EventArgs e)
        {
            nombreSelTextBox.Clear();
            habilitadoCheckBox.Checked = false;
        }


		/*

		private void fillFunctionalitiesTable() {
			this.funcionalidadesSelGrid.DataSource = FunctionalityController.getAvailableFunctionalities();
		}

		private void funcionalidadesSelGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
			if( canBind ) {
				addCheckboxColumn();
				setCheckBoxCellsStatus();
			}
		}


		private void addCheckboxColumn() {
			DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
			checkColumn.Name = "Funcionalidad Otorgada";
			checkColumn.TrueValue = true;
			checkColumn.FalseValue = false;
			checkColumn.HeaderText = "Funcionalidad Otorgada";
			checkColumn.Width = 50;
			checkColumn.ReadOnly = false;
			checkColumn.FillWeight = 10;
			this.funcionalidadesSelGrid.Columns.Add(checkColumn);
		}


		private void setCheckBoxCellsStatus() {

			canBind = false;

			List<Functionality> functionalities = FunctionalityController.getAvailableFunctionalitiesForRol(rol.getID());

		//	foreach( DataGridViewRow row in this.funcionalidadesSelGrid.Rows ) {
		//		row.Cells[3].Value = ( (Int32) row.Cells[0].Value ) == functionalities[row.Index].getID(); 		
		//	}

			for( int i = 0; i < this.funcionalidadesSelGrid.Rows.Count - 1; i++ ) {
				DataGridViewRow row = this.funcionalidadesSelGrid.Rows[i];
				row.Cells[2].Value = checkFunctionalityStatus(functionalities, (Int32) row.Cells[0].Value);		
			}

		
		}


		private Boolean checkFunctionalityStatus(List<Functionality> funcs, Int32 funID) {
			
			foreach(Functionality f in funcs) {
				if(f.getID() == funID) {
					return true;
				}
			}
			return false;
		}
		 * 
		 * */

		private void agregarButton_Click(object sender, EventArgs e) {
			using( var agregarForm = new AgregarFuncionalidadARol(rol) ) {

				var result = agregarForm.ShowDialog();

				if( agregarForm.DialogResult == DialogResult.OK ) {
					this.functionalityAction = "Agregar";

					this.selectedFunctionality.setID(agregarForm.selectedFunctionality.getID());
					this.selectedFunctionality.setDetalle(agregarForm.selectedFunctionality.getDetalle());

					this.functionalityText.Text = "Agregar funcionalidad: " + agregarForm.selectedFunctionality.getDetalle();
					this.functionalityText.Visible = true;
				}

			}
		}

		private void removerButton_Click(object sender, EventArgs e) {
			using( var removerForm = new RemoverFuncionalidadARol(rol) ) {

				var result = removerForm.ShowDialog();

				if( result == DialogResult.OK ) {
					this.functionalityAction = "Remover";

					this.selectedFunctionality.setID(removerForm.selectedFunctionality.getID());
					this.selectedFunctionality.setDetalle(removerForm.selectedFunctionality.getDetalle());

					this.functionalityText.Text = "Remover funcionalidad: " + removerForm.selectedFunctionality.getDetalle();
					this.functionalityText.Visible = true;
				}

			}

		}

		private void modificarSelButton_Click(object sender, EventArgs e) {

			if( !this.nombreSelTextBox.Text.Equals("")) {
				RolController.changeRolName(rol.getID(), this.nombreSelTextBox.Text.ToString());
			}

			if( functionalityAction == "Remover" ) {
				RolController.removeFunctionalityToRol(rol.getID(), selectedFunctionality.getID());
			}

			if( functionalityAction == "Agregar" ) {
				RolController.addFunctionalityToRol(rol.getID(), selectedFunctionality.getID());
			}

			if( this.habilitadoCheckBox.Checked != rol.getHabilitado()) {
				if( this.habilitadoCheckBox.Checked ) {
					RolController.habilitarRol(rol.getID());
				} else {
					RolController.deshabilitarRol(rol.getID());
				}
				this.rol.setHabilitado(this.habilitadoCheckBox.Checked);
			}

			this.DialogResult = DialogResult.OK;
			this.Close();


		
		}




    }








}
