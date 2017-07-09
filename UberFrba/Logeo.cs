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

            //using (cmd = new SqlCommand(string.Format("select r.ROL_DETALLE from DAVID_Y_LOS_COCODRILOS.ROL r"),
            //                            Conexion) ) ;
            //reader = cmd.ExecuteReader();
            
            //while (reader.Read())
            //{

            //comboBox1.Items.Add(reader.GetString(0));
                
            //}
            
           
            //reader.Close();

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



            try
            {
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                MessageBox.Show("estamos conectados");
                SqlCommand loginUsuario = new SqlCommand();
                SqlDataReader result;
               

                using (loginUsuario = new SqlCommand("DAVID_Y_LOS_COCODRILOS.INGRESAR_USUARIO", Conexion))
                 
                {
                    loginUsuario.CommandType = CommandType.StoredProcedure;
                    loginUsuario.Parameters.Add("@username", SqlDbType.Char);
                    loginUsuario.Parameters["@username"].Value = pUsername;
                    loginUsuario.Parameters.Add("@password", SqlDbType.Char);
                    loginUsuario.Parameters["@password"].Value = pContrasenia;
                }

                result =  loginUsuario.ExecuteReader();

                if (result.HasRows)
                {
                    Usuario.IdUsuario = result.GetInt32(0);//Asumiendo que la primera columna es DNI (ID)
                    if(result.HasRows.Equals(1))
                    {
                        Usuario.RolUsuario = result.GetInt32(1);
                        Menu menu = new Menu();
                        menu.ShowDialog(); 
                    }
                    else
                    {
                        SeleccionRol seleccionRol = new SeleccionRol();
                  
                        while (result.Read())
                        {
                        }


                        seleccionRol.ShowDialog();
                            
                    }
                }
                else
                {
                    
                    
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }

        }
    }
}
