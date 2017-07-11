using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.Abm_Rol {

	class RolController {


		public static DataTable findAvailableRol(String rolName) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand buscarRol = null;
			DataTable dataTable = new DataTable();
			SqlDataAdapter dataAdapter = new SqlDataAdapter();

			try {

				using( buscarRol = new SqlCommand("DAVID_Y_LOS_COCODRILOS.BUSCAR_ROLES_HABILITADOS", sqlConnection) ) {

					buscarRol.CommandType = CommandType.StoredProcedure;
					buscarRol.Parameters.Add("@detalle", SqlDbType.VarChar);
					buscarRol.Parameters["@detalle"].Value = rolName;

					dataAdapter.SelectCommand = buscarRol;
					dataAdapter.Fill(dataTable);
				}

			} catch( Exception e ) {
				throw;
			}

			sqlConnection.Close();

			return dataTable;

		}


		public static Int32 removeRol(Int32 id) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand removeRol = null;

			using( removeRol = new SqlCommand("DAVID_Y_LOS_COCODRILOS.INHABILITAR_ROL", sqlConnection) ) {

				removeRol.CommandType = CommandType.StoredProcedure;
				removeRol.Parameters.Add("@rol", SqlDbType.Int);
				removeRol.Parameters["@rol"].Value = id;

			}


			try {
				return (Int32) removeRol.ExecuteScalar();
			} catch( Exception e ) {
				throw;
			}


		}
	
	
	
	}




}
