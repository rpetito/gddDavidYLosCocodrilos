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

				using( buscarRol = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_ROLES_HABILITADOS", sqlConnection) ) {

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


		public static DataTable findAllRol(String rolName) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand buscarRol = null;
			DataTable dataTable = new DataTable();
			SqlDataAdapter dataAdapter = new SqlDataAdapter();

			try {

				using( buscarRol = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_TODOS_LOS_ROLES", sqlConnection) ) {

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



		public static Int32 removeFunctionalityToRol(Int32 rol, Int32 func) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand removerFunc = new SqlCommand("DAVID_Y_LOS_COCODRILOS.REMOVER_FUNCIONALIDAD_A_ROL", sqlConnection);

			removerFunc.CommandType = CommandType.StoredProcedure;
			removerFunc.Parameters.Add("@rol", SqlDbType.Int);
			removerFunc.Parameters["@rol"].Value = rol;
			removerFunc.Parameters.Add("@funcionalidad", SqlDbType.Int);
			removerFunc.Parameters["@funcionalidad"].Value = func;


			return (Int32) removerFunc.ExecuteScalar();

		}


		public static Int32 addFunctionalityToRol(Int32 rol, Int32 func) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand removerFunc = new SqlCommand("DAVID_Y_LOS_COCODRILOS.AGREGAR_FUNCIONALIDAD_A_ROL", sqlConnection);

			removerFunc.CommandType = CommandType.StoredProcedure;
			removerFunc.Parameters.Add("@rol", SqlDbType.Int);
			removerFunc.Parameters["@rol"].Value = rol;
			removerFunc.Parameters.Add("@funcionalidad", SqlDbType.Int);
			removerFunc.Parameters["@funcionalidad"].Value = func;


			return (Int32) removerFunc.ExecuteScalar();

		}


		public static Int32 changeRolName(Int32 rol, String name) { 
		
			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand removerFunc = new SqlCommand("DAVID_Y_LOS_COCODRILOS.MODIFICAR_NOMBRE_ROL", sqlConnection);

			removerFunc.CommandType = CommandType.StoredProcedure;
			removerFunc.Parameters.Add("@rol", SqlDbType.Int);
			removerFunc.Parameters["@rol"].Value = rol;
			removerFunc.Parameters.Add("@nuevoDetalle", SqlDbType.VarChar);
			removerFunc.Parameters["@nuevoDetalle"].Value = name;


			return (Int32) removerFunc.ExecuteScalar();
		

		}



		public static Int32 habilitarRol(Int32 rol) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand removerFunc = new SqlCommand("DAVID_Y_LOS_COCODRILOS.HABILITAR_ROL", sqlConnection);

			removerFunc.CommandType = CommandType.StoredProcedure;
			removerFunc.Parameters.Add("@rol", SqlDbType.Int);
			removerFunc.Parameters["@rol"].Value = rol;


			return (Int32) removerFunc.ExecuteScalar();

		}


		public static Int32 deshabilitarRol(Int32 rol) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand removerFunc = new SqlCommand("DAVID_Y_LOS_COCODRILOS.INHABILITAR_ROL", sqlConnection);

			removerFunc.CommandType = CommandType.StoredProcedure;
			removerFunc.Parameters.Add("@rol", SqlDbType.Int);
			removerFunc.Parameters["@rol"].Value = rol;

			return (Int32) removerFunc.ExecuteScalar();

		}

	
	
	
	}




}
