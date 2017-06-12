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
            Int32 id = 0;
            Int32 intentos = 0;


            try
            {
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                MessageBox.Show("estamos conectados");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }
            Menu menu = new Menu();
            menu.ShowDialog();

        }
    }
}
