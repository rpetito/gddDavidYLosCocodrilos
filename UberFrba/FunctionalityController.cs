using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba {



	class FunctionalityController {


		public static DataTable getAvailableFunctionalities() {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand buscarFuncionlidades = null;
			DataTable dataTable = new DataTable();
			SqlDataAdapter dataAdapter = new SqlDataAdapter();

			try {

				using( buscarFuncionlidades = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_FUNCIONALIDADES", sqlConnection) ) {
					dataAdapter.SelectCommand = buscarFuncionlidades;
					dataAdapter.Fill(dataTable);
				}

				return dataTable;

			} catch( Exception e ) {
				throw;
			} finally {
				sqlConnection.Close();
			}


		}



		public static List<Functionality> getAvailableFunctionalitiesForRol(Int32 rol) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand buscarFuncionlidades = null;

			using( buscarFuncionlidades = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_FUNCIONES_HABILITADAS_PARA_ROL", sqlConnection) ) {
				buscarFuncionlidades.CommandType = CommandType.StoredProcedure;
				buscarFuncionlidades.Parameters.Add("@rol", SqlDbType.Int);
				buscarFuncionlidades.Parameters["@rol"].Value = rol;
			}

			try {

				List<Functionality> functionalities = new List<Functionality>();
				SqlDataReader reader = buscarFuncionlidades.ExecuteReader();

				while( reader.Read() ) {
					Functionality f = new Functionality();
					f.setID(reader.GetInt32(0));
					f.setDetalle(reader.GetString(1));
					functionalities.Add(f);
				}

				return functionalities;

			} catch( Exception e ) {
				throw;
			} finally {
				sqlConnection.Close();
			}


		}


		public static DataTable getAllFunctionalitiesForRol(Int32 rol) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand buscarFuncionlidades = null;
			DataTable dataTable = new DataTable();
			SqlDataAdapter dataAdapter = new SqlDataAdapter();

			try {

				using( buscarFuncionlidades = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_TODAS_LAS_FUNCIONES_PARA_ROL", sqlConnection) ) {
					buscarFuncionlidades.CommandType = CommandType.StoredProcedure;
					buscarFuncionlidades.Parameters.Add("@rol", SqlDbType.Int);
					buscarFuncionlidades.Parameters["@rol"].Value = rol;
					dataAdapter.SelectCommand = buscarFuncionlidades;
					dataAdapter.Fill(dataTable);
				}

				return dataTable;

			} catch( Exception e ) {
				throw;
			} finally {
				sqlConnection.Close();
			}

		}



		public static DataTable getFunctionalitiesToAdd(Int32 rol) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand buscarFuncionlidades = null;
			DataTable dataTable = new DataTable();
			SqlDataAdapter dataAdapter = new SqlDataAdapter();

			try {

				using( buscarFuncionlidades = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_FUNCIONALIDADES_NO_ASIGNADAS_A_ROL", sqlConnection) ) {
					buscarFuncionlidades.CommandType = CommandType.StoredProcedure;
					buscarFuncionlidades.Parameters.Add("@rol", SqlDbType.Int);
					buscarFuncionlidades.Parameters["@rol"].Value = rol;
					dataAdapter.SelectCommand = buscarFuncionlidades;
					dataAdapter.Fill(dataTable);
				}

				return dataTable;

			} catch( Exception e ) {
				throw;
			} finally {
				sqlConnection.Close();
			}

		}



		







	}







}
