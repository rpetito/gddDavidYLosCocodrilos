﻿using System;
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
            Int32 pRol = comboBox1.SelectedIndex + 1;
            Int32 id = 0;
            Int32 intentos = 0;


            try
            {
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                MessageBox.Show("estamos conectados");
                SqlCommand loginUsuario = new SqlCommand();
                SqlDataReader reader;
               

                using (loginUsuario = new SqlCommand("DAVID_Y_LOS_COCODRILOS.INGRESAR_USUARIO", Conexion))
                 
                {
                    loginUsuario.CommandType = CommandType.StoredProcedure;
                    loginUsuario.Parameters.Add("@username", SqlDbType.Char);
                    loginUsuario.Parameters["@username"].Value = pUsername;
                    loginUsuario.Parameters.Add("@password", SqlDbType.Char);
                    loginUsuario.Parameters["@password"].Value = pContrasenia;
                    loginUsuario.Parameters.Add("@rol", SqlDbType.Int);
                    loginUsuario.Parameters["@rol"].Value = pRol;
                }

                reader = loginUsuario.ExecuteReader();

                bool v = reader.Read();
                if (v)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1}", reader.GetInt32(0), reader.GetString(1));
                        }
                        
                    }
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    
                    Menu menu = new Menu();
                    menu.ShowDialog(); ;
                }
                else {
                    MessageBox.Show("Logeo incorrecto.", "Afuera");
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }

        }
    }
}
