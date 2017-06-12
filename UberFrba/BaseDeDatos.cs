using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class BaseDeDatos
    {
        public static object BD_Conexion { get;  set; }

        public static string ObtenerCadenaConexion()
        {
            return Properties.Settings.Default.GD1C2017ConnectionString;
        }

        public static SqlConnection ObternerConexion()
        {
            SqlConnection Con = new SqlConnection(ObtenerCadenaConexion());
            Con.Open();
            return Con;

        }
    }
}
