using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba {


	class UsuarioController {

		public static Int32 altaOModificarUsuario(UsuarioData usuario, Int32 rol, String procedureName) {

			SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
			SqlCommand crearChofer = null;

			try {
				using( crearChofer = new SqlCommand("DAVID_Y_LOS_COCODRILOS." + procedureName, sqlConnection) ) {
					crearChofer.CommandType = CommandType.StoredProcedure;
					crearChofer.Parameters.Add("@rol", SqlDbType.Int);
					crearChofer.Parameters["@rol"].Value = rol;
					crearChofer.Parameters.Add("@nombre", SqlDbType.VarChar);
					crearChofer.Parameters["@nombre"].Value = usuario.getNombre();
					crearChofer.Parameters.Add("@apellido", SqlDbType.VarChar);
					crearChofer.Parameters["@apellido"].Value = usuario.getApellido();
					crearChofer.Parameters.Add("@dni", SqlDbType.Decimal);
					crearChofer.Parameters["@dni"].Value = usuario.getDNI();
					crearChofer.Parameters.Add("@mail", SqlDbType.VarChar);
					crearChofer.Parameters["@mail"].Value = usuario.getMail();
					crearChofer.Parameters.Add("@telefono", SqlDbType.Char);
					crearChofer.Parameters["@telefono"].Value = usuario.getTelefono();
					crearChofer.Parameters.Add("@direccion", SqlDbType.VarChar);
					crearChofer.Parameters["@direccion"].Value = usuario.getDireccion();
					crearChofer.Parameters.Add("@piso", SqlDbType.Int);
					crearChofer.Parameters["@piso"].Value = usuario.getPiso();
					crearChofer.Parameters.Add("@departamento", SqlDbType.Char);
					crearChofer.Parameters["@departamento"].Value = usuario.getDpto();
					crearChofer.Parameters.Add("@localidad", SqlDbType.VarChar);
					crearChofer.Parameters["@localidad"].Value = usuario.getLocalidad();
					crearChofer.Parameters.Add("@codPos", SqlDbType.VarChar);
					crearChofer.Parameters["@codPos"].Value = usuario.getCodPos();
					crearChofer.Parameters.Add("@fechaNac", SqlDbType.DateTime);
					crearChofer.Parameters["@fechaNac"].Value = usuario.getFechaNac();
					if( procedureName == "ALTA_USUARIO" ) {
						crearChofer.Parameters.Add("@username", SqlDbType.Char);
						crearChofer.Parameters["@username"].Value = usuario.getUsername();
						crearChofer.Parameters.Add("@password", SqlDbType.Char);
						crearChofer.Parameters["@password"].Value = usuario.getPassword();
					} else {
						crearChofer.Parameters.Add("@habilitado", SqlDbType.Int);
						crearChofer.Parameters["@habilitado"].Value = usuario.getHabilitadoInt();
					}

					Int32 result = Convert.ToInt32(crearChofer.ExecuteScalar());
					return result;
				}
			} catch( Exception ex ) {
				throw;
				MessageBox.Show(ex.ToString(), "there was an issue!");
			} finally {
				sqlConnection.Close();
			}

		}



		public static DataTable buscarUsuario(UsuarioData usuario, Int32 rol) {

			SqlConnection Conexion = BaseDeDatos.ObternerConexion();
			SqlCommand buscarCliente = new SqlCommand();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter();
			String dni;
			try {

				using( buscarCliente = new SqlCommand("DAVID_Y_LOS_COCODRILOS.BUSCAR_USUARIO", Conexion) ) {
					buscarCliente.CommandType = CommandType.StoredProcedure;
					buscarCliente.Parameters.Add("@rol", SqlDbType.Int);
					buscarCliente.Parameters["@rol"].Value = 2;
					buscarCliente.Parameters.Add("@nombre", SqlDbType.Char);
					buscarCliente.Parameters["@nombre"].Value = usuario.getNombre();
					buscarCliente.Parameters.Add("@apellido", SqlDbType.Char);
					buscarCliente.Parameters["@apellido"].Value = usuario.getApellido();
					buscarCliente.Parameters.Add("@dni", SqlDbType.Decimal);
					buscarCliente.Parameters["@dni"].Value = usuario.getDNI();
					da.SelectCommand = buscarCliente;
					da.Fill(dt);

					return dt;
				}
			} catch( Exception ex ) {
				MessageBox.Show(ex.ToString(), "there was an issue!");
				throw;
			} finally {
				Conexion.Close();
			}
		
		
		}



		public static Int32 bajaUsuario(DataGridViewCellEventArgs e, DataGridView gridView, Int32 rol) {

			if( e.ColumnIndex == 0 && e.RowIndex >= 0 ) {
				//tirar un mensaje para confirmar si el usuario esta seguro
				//si selecciona SI
				Decimal dni = (Decimal) gridView.SelectedCells[3].Value;
				SqlConnection Conexion = BaseDeDatos.ObternerConexion();
				SqlCommand eliminarChofer = new SqlCommand();

				try {
					using( eliminarChofer = new SqlCommand("DAVID_Y_LOS_COCODRILOS.INHABILITAR_USUARIO_ROL_PARTICULAR", Conexion) ) {
						eliminarChofer.CommandType = CommandType.StoredProcedure;
						eliminarChofer.Parameters.Add("@rol", SqlDbType.Int);
						eliminarChofer.Parameters["@rol"].Value = rol;
						eliminarChofer.Parameters.Add("@dni", SqlDbType.Decimal);
						eliminarChofer.Parameters["@dni"].Value = dni;

						Int32 result = Convert.ToInt32(eliminarChofer.ExecuteScalar());
						return result;

					}

				} catch( Exception ex ) {
					MessageBox.Show(ex.ToString(), "there was an issue!");
					throw;
				} finally {
					Conexion.Close();
				}

			} else {

				return -1;
			}


        }

		



	}





}
