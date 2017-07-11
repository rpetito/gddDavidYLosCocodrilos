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

namespace UberFrba.Abm_Chofer
{
    public partial class NuevoChofer : Form
    {
        public NuevoChofer()
        {
            InitializeComponent();
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand llenarRoles = new SqlCommand();
            SqlDataReader rolReader;

            using (llenarRoles = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_ROLES",
                                        Conexion))
            {
                  llenarRoles.CommandType = CommandType.StoredProcedure;
            }

            rolReader = llenarRoles.ExecuteReader();

            while (rolReader.Read())
            {
            rolComboBox.Items.Add(rolReader.GetString(1));
            }

            rolReader.Close();
            Conexion.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            dniTextBox.Clear();
            nacimientoDatePicker.ResetText();
            telefonoTextBox.Clear();
            direccionTextBox.Clear();
            localidadTextBox.Clear();
            pisoTextBox.Clear();
            departamentoTextBox.Clear();
            mailTextBox.Clear();
            usuarioTextBox.Clear();
            contraseniaTextBox.Clear();
            repetirTextBox.Clear();
            rolComboBox.ResetText();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand crearChofer = new SqlCommand();

            if (string.IsNullOrWhiteSpace(nombreTextBox.Text)
                    | string.IsNullOrWhiteSpace(apellidoTextBox.Text)
                    | string.IsNullOrWhiteSpace(dniTextBox.Text)
                    | string.IsNullOrWhiteSpace(nacimientoDatePicker.Text)
                    | string.IsNullOrWhiteSpace(telefonoTextBox.Text)
                    | string.IsNullOrWhiteSpace(direccionTextBox.Text)
                    | string.IsNullOrWhiteSpace(pisoTextBox.Text)
                    | string.IsNullOrWhiteSpace(departamentoTextBox.Text)
                    | string.IsNullOrWhiteSpace(localidadTextBox.Text)
                    | string.IsNullOrWhiteSpace(mailTextBox.Text)
                    | string.IsNullOrWhiteSpace(usuarioTextBox.Text)
                    | string.IsNullOrWhiteSpace(contraseniaTextBox.Text)
                    | string.IsNullOrWhiteSpace(repetirTextBox.Text)
                    | string.IsNullOrWhiteSpace(rolComboBox.Text))
            {
                MessageBox.Show("Por Favor completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (contraseniaTextBox.Text != repetirTextBox.Text)
            {
                contraseniaTextBox.ResetText();
                repetirTextBox.ResetText();
                MessageBox.Show("No coinciden las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    using (crearChofer = new SqlCommand("DAVID_Y_LOS_COCODRILOS.ALTA_USUARIO", Conexion))
                    {
                        crearChofer.CommandType = CommandType.StoredProcedure;
                        crearChofer.Parameters.Add("@rol", SqlDbType.Int);
                        crearChofer.Parameters["@rol"].Value = rolComboBox.Text;//rol no es int
                        crearChofer.Parameters.Add("@nombre", SqlDbType.Char);
                        crearChofer.Parameters["@nombre"].Value = nombreTextBox.Text;
                        crearChofer.Parameters.Add("@apellido", SqlDbType.Char);
                        crearChofer.Parameters["@apellido"].Value = apellidoTextBox.Text;
                        crearChofer.Parameters.Add("@dni", SqlDbType.Decimal);
                        crearChofer.Parameters["@dni"].Value = dniTextBox.Text;
                        crearChofer.Parameters.Add("@mail", SqlDbType.Char);
                        crearChofer.Parameters["@mail"].Value = mailTextBox.Text;
                        crearChofer.Parameters.Add("@telefono", SqlDbType.Char);
                        crearChofer.Parameters["@telefono"].Value = telefonoTextBox.Text;
                        crearChofer.Parameters.Add("@direccion", SqlDbType.Char);
                        crearChofer.Parameters["@direccion"].Value = direccionTextBox.Text;
                        crearChofer.Parameters.Add("@piso", SqlDbType.Int);
                        crearChofer.Parameters["@piso"].Value = pisoTextBox.Text;
                        crearChofer.Parameters.Add("@departamento", SqlDbType.Char);
                        crearChofer.Parameters["@departamento"].Value = departamentoTextBox.Text;
                        crearChofer.Parameters.Add("@localidad", SqlDbType.Char);
                        crearChofer.Parameters["@localidad"].Value = localidadTextBox.Text;
                        crearChofer.Parameters.Add("@codPos", SqlDbType.Int);
                        crearChofer.Parameters["@codPos"].Value = null;//turbio
                        crearChofer.Parameters.Add("@fechaNac", SqlDbType.Date);
                        crearChofer.Parameters["@fechaNac"].Value = nacimientoDatePicker.Text;
                        crearChofer.Parameters.Add("@username", SqlDbType.Char);
                        crearChofer.Parameters["@username"].Value = usuarioTextBox.Text;
                        crearChofer.Parameters.Add("@password", SqlDbType.Char);
                        crearChofer.Parameters["@password"].Value = contraseniaTextBox.Text;
                    }
                }
                catch (Exception ex){
                    MessageBox.Show(ex.ToString(), "there was an issue!");
                }
            }
            Conexion.Close();
        }
    }
}
