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
    public partial class NuevoRol : Form
    {


        public NuevoRol()
        {
            InitializeComponent();
			DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
			checkColumn.Name = "Agregar";
			checkColumn.HeaderText = "Agregar";
			checkColumn.Width = 50;
			checkColumn.ReadOnly = false;
			checkColumn.TrueValue = true;
			checkColumn.FalseValue = false;
			checkColumn.FillWeight = 10;
			this.funcionalidadesGrid.Columns.Add(checkColumn);
			fillDataGrid();
        }



		private void fillDataGrid() {
			this.funcionalidadesGrid.DataSource = FunctionalityController.getAllFunctionalities();
		}



        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            funcionalidadesGrid.ClearSelection();
        }




        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		private void crearButton_Click(object sender, EventArgs e) {

			if( !this.nombreTextBox.Text.Equals("") ) {

				Int32 newRolID = RolController.crearRol(this.nombreTextBox.Text.ToString());

				if( newRolID != 999 ) {
					foreach( DataGridViewRow row in this.funcionalidadesGrid.Rows ) {
						Boolean selected = row.Cells[0].Value == null ? false : true;
						if( selected ) {
							Int32 funcID = (Int32) row.Cells[1].Value;
							RolController.addFunctionalityToRol(newRolID, funcID);
						}
					}
				} else {
					MessageBox.Show("Error al agregar el rol.");
				} 

			} else {
				MessageBox.Show("Ingrese un nombre.");
			}

			this.Close();

		}

		



    }




}
