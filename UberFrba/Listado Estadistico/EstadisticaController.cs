using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Listado_Estadistico
{
    class EstadisticaController
    {

        public static DataTable getCaso1(int anio, int trimestre)
        {

            SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
            SqlCommand estadistica = null;
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            
            try
            {

                using (estadistica = new SqlCommand("DAVID_Y_LOS_COCODRILOS.ESTADISTICA_RECAUDACION", sqlConnection))
                {

                    estadistica.CommandType = CommandType.StoredProcedure;
                    estadistica.Parameters.Add("@anio", SqlDbType.Int);
                    estadistica.Parameters["@anio"].Value = anio;
                    estadistica.Parameters.Add("@mes_inicio", SqlDbType.Int);
                    estadistica.Parameters["@mes_inicio"].Value = (trimestre*3-2);
                    estadistica.Parameters.Add("@mes_fin", SqlDbType.Int);
                    estadistica.Parameters["@mes_fin"].Value = trimestre*3;

                    dataAdapter.SelectCommand = estadistica;
                    dataAdapter.Fill(dataTable);
                }

            }
            catch (Exception e)
            {
                throw;
            } finally {
                sqlConnection.Close();
            }

            return dataTable;

        }

        public static DataTable getCaso2(int anio, int trimestre)
        {

            SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
            SqlCommand estadistica = null;
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            try
            {

                using (estadistica = new SqlCommand("DAVID_Y_LOS_COCODRILOS.ESTADISTICA_VIAJES_MAS_LARGOS", sqlConnection))
                {

                    estadistica.CommandType = CommandType.StoredProcedure;
                    estadistica.Parameters.Add("@anio", SqlDbType.Int);
                    estadistica.Parameters["@anio"].Value = anio;
                    estadistica.Parameters.Add("@mes_inicio", SqlDbType.Int);
                    estadistica.Parameters["@mes_inicio"].Value = (trimestre * 3 - 2);
                    estadistica.Parameters.Add("@mes_fin", SqlDbType.Int);
                    estadistica.Parameters["@mes_fin"].Value = trimestre * 3;

                    dataAdapter.SelectCommand = estadistica;
                    dataAdapter.Fill(dataTable);
                }

            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }

            return dataTable;

        }

        public static DataTable getCaso3(int anio, int trimestre)
        {

            SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
            SqlCommand estadistica = null;
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            try
            {

                using (estadistica = new SqlCommand("DAVID_Y_LOS_COCODRILOS.ESTADISTICA_CLIENTES_CONSUMO", sqlConnection))
                {

                    estadistica.CommandType = CommandType.StoredProcedure;
                    estadistica.Parameters.Add("@anio", SqlDbType.Int);
                    estadistica.Parameters["@anio"].Value = anio;
                    estadistica.Parameters.Add("@mes_inicio", SqlDbType.Int);
                    estadistica.Parameters["@mes_inicio"].Value = (trimestre * 3 - 2);
                    estadistica.Parameters.Add("@mes_fin", SqlDbType.Int);
                    estadistica.Parameters["@mes_fin"].Value = trimestre * 3;

                    dataAdapter.SelectCommand = estadistica;
                    dataAdapter.Fill(dataTable);
                }

            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }

            return dataTable;

        }

        public static DataTable getCaso4(int anio, int trimestre)
        {

            SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
            SqlCommand estadistica = null;
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            try
            {

                using (estadistica = new SqlCommand("DAVID_Y_LOS_COCODRILOS.ESTADISTICA_CLIENTE_AUTOMOVIL", sqlConnection))
                {

                    estadistica.CommandType = CommandType.StoredProcedure;
                    estadistica.Parameters.Add("@anio", SqlDbType.Int);
                    estadistica.Parameters["@anio"].Value = anio;
                    estadistica.Parameters.Add("@mes_inicio", SqlDbType.Int);
                    estadistica.Parameters["@mes_inicio"].Value = (trimestre * 3 - 2);
                    estadistica.Parameters.Add("@mes_fin", SqlDbType.Int);
                    estadistica.Parameters["@mes_fin"].Value = trimestre * 3;

                    dataAdapter.SelectCommand = estadistica;
                    dataAdapter.Fill(dataTable);
                }

            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }

            return dataTable;

        }


    }











    }
