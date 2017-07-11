using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba {

	class MenuController {

		public static Form getViewForFunctionality(int id) {

			Form form = null;

			switch (id) {
			
				case 1:
					form = new Abm_Automovil.Automovil();
					break;
				case 2:
					form = new Abm_Turno.Turno();
					break;
				case 3:
					form = new Abm_Rol.Rol();
					break;
				case 4:
					form = new Administrador.Administrador();
					break;
				case 5:
					form = new Abm_Chofer.Chofer();
					break;
				case 6:
					form = new Abm_Cliente.Clientes();
					break;
				case 7:
					form = new Registro_Viajes.Registro();
					break;
				case 8:
					form = new Rendicion_Viajes.Rendicion();
					break;
				case 9:
					form = new Facturacion.Facturacion();
					break;
				case 10:
					form = new Listado_Estadistico.Form1();
					break;

			}


			return form;

		}


	}


}
