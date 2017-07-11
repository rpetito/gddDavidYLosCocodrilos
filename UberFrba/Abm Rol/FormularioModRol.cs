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

		private Rol rol;
		private Boolean canBind = true;

		

        public FormularioModRol(Rol rol) {
            InitializeComponent();
			this.rol = rol;
			fillFunctionalitiesTable();
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




    }








}
