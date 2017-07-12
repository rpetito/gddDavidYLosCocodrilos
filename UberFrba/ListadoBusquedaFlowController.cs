using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Abm_Chofer;
using UberFrba.Abm_Cliente;

namespace UberFrba {


	class ListadoBusquedaFlowController {


		public static void doFlow(DataGridViewCellEventArgs e, DataGridView datagrid, Int32 rol) {


			if( e.ColumnIndex == 0 && e.RowIndex >= 0 ) {
				UsuarioSeleccionado.getInstance().setNombre(datagrid.CurrentRow.Cells[1].Value.ToString());
				UsuarioSeleccionado.getInstance().setApellido(datagrid.CurrentRow.Cells[2].Value.ToString());
				UsuarioSeleccionado.getInstance().setDni((Decimal) datagrid.CurrentRow.Cells[3].Value);
				UsuarioSeleccionado.getInstance().setMail(datagrid.CurrentRow.Cells[4].Value.ToString());
				UsuarioSeleccionado.getInstance().setTelefono(datagrid.CurrentRow.Cells[5].Value.ToString());
				UsuarioSeleccionado.getInstance().setDireccion(datagrid.CurrentRow.Cells[6].Value.ToString());

				if( string.IsNullOrWhiteSpace(datagrid.CurrentRow.Cells[7].Value.ToString()) )
					UsuarioSeleccionado.getInstance().setPiso(0);
				else
					UsuarioSeleccionado.getInstance().setPiso((Int32) datagrid.CurrentRow.Cells[7].Value);

				if( string.IsNullOrWhiteSpace(datagrid.CurrentRow.Cells[8].Value.ToString()) )
					UsuarioSeleccionado.getInstance().setDepartamento("-");
				else
					UsuarioSeleccionado.getInstance().setDepartamento(datagrid.CurrentRow.Cells[8].Value.ToString());

				UsuarioSeleccionado.getInstance().setLocalidad(datagrid.CurrentRow.Cells[9].Value.ToString());
				UsuarioSeleccionado.getInstance().setCodigoPostal(datagrid.CurrentRow.Cells[10].Value.ToString());
				UsuarioSeleccionado.getInstance().setFechaNacimiento((DateTime) datagrid.CurrentRow.Cells[11].Value);
				UsuarioSeleccionado.getInstance().setHabilitado((Int32) datagrid.CurrentRow.Cells[13].Value);

				Form formToGo = null;
				if( rol == 2 ) {
					formToGo = new FormularioModCliente();
				}
				if( rol == 3 ) {
					formToGo = new FormularioModChofer();
				}
				formToGo.ShowDialog();


			}

		}

	}



}
