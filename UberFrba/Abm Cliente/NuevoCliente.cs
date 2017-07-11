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

namespace UberFrba.Abm_Cliente
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
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
            codigoTextBox.Clear();
            mailTextBox.Clear();
            rolComboBox.ResetText();
            usuarioTextBox.Clear();
            contraseniaTextBox.Clear();
            repetirTextBox.Clear();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand crearCliente = new SqlCommand();

            if (string.IsNullOrWhiteSpace(nombreTextBox.Text)
                    | string.IsNullOrWhiteSpace(apellidoTextBox.Text)
                    | string.IsNullOrWhiteSpace(dniTextBox.Text)
                    | string.IsNullOrWhiteSpace(nacimientoDatePicker.Text)
                    | string.IsNullOrWhiteSpace(telefonoTextBox.Text)
                    | string.IsNullOrWhiteSpace(direccionTextBox.Text)
                    | string.IsNullOrWhiteSpace(localidadTextBox.Text)
                    | string.IsNullOrWhiteSpace(pisoTextBox.Text)
                    | string.IsNullOrWhiteSpace(departamentoTextBox.Text)
                    | string.IsNullOrWhiteSpace(codigoTextBox.Text)
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
                    using (crearCliente = new SqlCommand("DAVID_Y_LOS_COCODRILOS.ALTA_USUARIO", Conexion))
                    {
                        crearCliente.CommandType = CommandType.StoredProcedure;
                        crearCliente.Parameters.Add("@rol", SqlDbType.Int);
                        crearCliente.Parameters["@rol"].Value = rolComboBox.Text;//rol no es int
                        crearCliente.Parameters.Add("@nombre", SqlDbType.Char);
                        crearCliente.Parameters["@nombre"].Value = nombreTextBox.Text;
                        crearCliente.Parameters.Add("@apellido", SqlDbType.Char);
                        crearCliente.Parameters["@apellido"].Value = apellidoTextBox.Text;
                        crearCliente.Parameters.Add("@dni", SqlDbType.Decimal);
                        crearCliente.Parameters["@dni"].Value = dniTextBox.Text;
                        crearCliente.Parameters.Add("@mail", SqlDbType.Char);
                        crearCliente.Parameters["@mail"].Value = mailTextBox.Text;
                        crearCliente.Parameters.Add("@telefono", SqlDbType.Char);
                        crearCliente.Parameters["@telefono"].Value = telefonoTextBox.Text;
                        crearCliente.Parameters.Add("@direccion", SqlDbType.Char);
                        crearCliente.Parameters["@direccion"].Value = direccionTextBox.Text;
                        crearCliente.Parameters.Add("@piso", SqlDbType.Int);
                        crearCliente.Parameters["@piso"].Value = pisoTextBox.Text;
                        crearCliente.Parameters.Add("@departamento", SqlDbType.Char);
                        crearCliente.Parameters["@departamento"].Value = departamentoTextBox.Text;
                        crearCliente.Parameters.Add("@localidad", SqlDbType.Char);
                        crearCliente.Parameters["@localidad"].Value = localidadTextBox.Text;
                        crearCliente.Parameters.Add("@codPos", SqlDbType.Int);
                        crearCliente.Parameters["@codPos"].Value = null;//turbio
                        crearCliente.Parameters.Add("@fechaNac", SqlDbType.Date);
                        crearCliente.Parameters["@fechaNac"].Value = nacimientoDatePicker.Text;
                        crearCliente.Parameters.Add("@username", SqlDbType.Char);
                        crearCliente.Parameters["@username"].Value = usuarioTextBox.Text;
                        crearCliente.Parameters.Add("@password", SqlDbType.Char);
                        crearCliente.Parameters["@password"].Value = contraseniaTextBox.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "there was an issue!");
                }
            }
            Conexion.Close();
        }
    }
}
