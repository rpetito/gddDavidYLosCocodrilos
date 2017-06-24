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
    public partial class Logeo : Form
    {
        public Logeo()
        {
            InitializeComponent();
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            using (cmd = new SqlCommand(" SELECT r.rol_detalle " +
                                        "from DAVID_Y_LOS_COCODRILOS.rol r ",
                                        Conexion) ) ;
            reader = cmd.ExecuteReader();





            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("chofer");
            comboBox1.Items.Add("cliente");

        }

        public string Password { get; set; }

        public Boolean isValidPassword(string password)
        {
            string hashedPassword = hashPassword(password);
            return this.Password.Equals(hashedPassword);
        }

        private string hashPassword(string password)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] hash = System.Security.Cryptography.SHA256.Create().ComputeHash(data);

            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String pUsername = userTextBox.Text;
            String pContrasenia = passwordTextBox.Text;
            String pRol = comboBox1.Text;
            
            Int32 id = 0;
            Int32 intentos = 0;


            try
            {
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                MessageBox.Show("estamos conectados", pRol);
                Console.Write(pRol);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }



            Menu menu = new Menu();
            menu.ShowDialog();

        }
    }
}
