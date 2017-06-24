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

            using (cmd = new SqlCommand(string.Format("select r.ROL_DETALLE from DAVID_Y_LOS_COCODRILOS.ROL r"),
                                        Conexion) ) ;
            reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {

            comboBox1.Items.Add(reader.GetString(0));
                
            }
            
           
            reader.Close();

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
                SqlCommand loginUsuario = new SqlCommand();
                SqlDataReader reader;
                SqlParameter username = new SqlParameter();
                username.ParameterName = "@username";
                username.Value = pUsername;
                SqlParameter password = new SqlParameter();
                password.ParameterName = "@password";
                password.Value = pContrasenia;
                SqlParameter rol = new SqlParameter();
                rol.ParameterName = "@rol";
                rol.Value = pRol;

                loginUsuario.Parameters.Add(username);
                loginUsuario.Parameters.Add(password);
                loginUsuario.Parameters.Add(rol);


                using ( loginUsuario = new SqlCommand(string.Format("Select u.usuario_dni " +
                                                                    "FROM DAVID_Y_LOS_COCODRILOS.USUARIO U join DAVID_Y_LOS_COCODRILOS.ROL_USUARIO ru " +
                                                                    "on u.USUARIO_DNI = ru.USROL_USUARIO join DAVID_Y_LOS_COCODRILOS.ROL r " +
                                                                    "on r.ROL_ID = ru.USROL_ROL " +
                                                                    "WHERE r.ROL_DETALLE = @rol and u.USUARIO_USERNAME = @username and u.USUARIO_PASSWORD = @password"
                                                                    ),
                            Conexion)) ;
                reader = loginUsuario.ExecuteReader();

                while (reader.Read())
                {

                    Console.WriteLine(reader.GetInt32(0));

                }
                reader.Close();

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
