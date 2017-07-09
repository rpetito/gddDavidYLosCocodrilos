using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba
{
    public partial class SeleccionRol : Form
    {
        public SeleccionRol()
        {
            InitializeComponent();
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            List<int> Roles;

            using (cmd = new SqlCommand("DAVID_Y_LOS_COCODRILOS.",
                                        Conexion)) ;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                rolComboBox.Items.Add(reader.GetString(1));

            }


            reader.Close();
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {

        }
    }
}
