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
            passwordTextBox.PasswordChar = '*';

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

            return "0x" + BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
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
                    String passHasheado = hashPassword(pContrasenia);
                    loginUsuario.Parameters["@password"].Value = passHasheado;
                }

                result =  loginUsuario.ExecuteReader();

                Boolean success = true;

                while (result.Read())
                {
                    if (result.VisibleFieldCount == 3)
                    {
                        Usuario.getInstance().setDNI(result.GetDecimal(0));

                        Rol rol = new Rol();
                        rol.setID(result.GetInt32(1));
                        rol.setDetalle(result.GetString(2));

                        Usuario.getInstance().addRol(rol);
                       
                    }
                    else
                    {
                        if (result.GetInt32(0) == 0)
                            MessageBox.Show("Usuario inhabilitado", "hola");
                        else
                            MessageBox.Show("Usuario o Contraseña incorrecto/s");

                        success = false;
                    }


                }

                if (success)
                {
                    if (Usuario.getInstance().getRoles().Count == 1)
                    {
                        Usuario.getInstance().setRolSeleccionado(Usuario.getInstance().getRoles()[0]);
                        Menu menu = new Menu();
                        menu.ShowDialog();
                    } else if( Usuario.getInstance().getRoles().Count > 0 ) {
						SeleccionRol rolSeleccionado = new SeleccionRol();
						rolSeleccionado.ShowDialog();
					} else {
						MessageBox.Show("El usuario no tiene roles disponibles");
					}
                }

                Conexion.Close();
              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }
        
        }
    }
}
