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
    public partial class FormularioModCliente : Form
    {
        public FormularioModCliente()
        {
            InitializeComponent();
            nombreSelTextBox.Text = UsuarioSeleccionado.getInstance().getNombre();
            apellidoSelTextBox.Text = UsuarioSeleccionado.getInstance().getApellido();
            dniSelTextBox.Text = UsuarioSeleccionado.getInstance().getDni().ToString();
            mailSelTextBox.Text = UsuarioSeleccionado.getInstance().getMail();
            telefonoSelTextBox.Text = UsuarioSeleccionado.getInstance().getTelefono();
            direccionSelTextBox.Text = UsuarioSeleccionado.getInstance().getDireccion();
            pisoSelTextBox.Text = UsuarioSeleccionado.getInstance().getPiso().ToString();
            departamentoSelTextBox.Text = UsuarioSeleccionado.getInstance().getDepartamento();
            localidadSelTextBox.Text = UsuarioSeleccionado.getInstance().getLocalidad();
            fechaNacimientoSelDatePicker.Text = UsuarioSeleccionado.getInstance().getFechaNacimiento().ToString();
            if (UsuarioSeleccionado.getInstance().getHabilitado() == 1)
                habilitadoCheckBox.Checked = true;
            else habilitadoCheckBox.Checked = false;

            UsuarioSeleccionado.setInstance();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarSelButton_Click(object sender, EventArgs e)
        {
            nombreSelTextBox.Clear();
            apellidoSelTextBox.Clear();
            dniSelTextBox.Clear();
            fechaNacimientoSelDatePicker.ResetText();
            telefonoSelTextBox.Clear();
            direccionSelTextBox.Clear();
            localidadSelTextBox.Clear();
            pisoSelTextBox.Clear();
            departamentoSelTextBox.Clear();
            codigoSelTextBox.Clear();
            mailSelTextBox.Clear();
            habilitadoCheckBox.Checked = false;
        }

        private void modificarSelButton_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand modificarCliente = new SqlCommand();

            if (string.IsNullOrWhiteSpace(nombreSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(apellidoSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(fechaNacimientoSelDatePicker.Text)
                    | string.IsNullOrWhiteSpace(telefonoSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(direccionSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(pisoSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(departamentoSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(localidadSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(mailSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(codigoSelTextBox.Text))
            {
                MessageBox.Show("Por Favor completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int habilitado;
                    if (habilitadoCheckBox.Checked)
                        habilitado = 1;
                    else habilitado = 0;

                    using (modificarCliente = new SqlCommand("DAVID_Y_LOS_COCODRILOS.MODIFICAR_USUARIO", Conexion))
                    {
                        modificarCliente.CommandType = CommandType.StoredProcedure;
						modificarCliente.Parameters.Add("@rol", SqlDbType.Int);
						modificarCliente.Parameters["@rol"].Value = 2;
						modificarCliente.Parameters.Add("@dni", SqlDbType.Decimal);
						modificarCliente.Parameters["@dni"].Value = this.dniSelTextBox.Text;
                        modificarCliente.Parameters.Add("@nombre", SqlDbType.Char);
                        modificarCliente.Parameters["@nombre"].Value = nombreSelTextBox.Text;
                        modificarCliente.Parameters.Add("@apellido", SqlDbType.Char);
                        modificarCliente.Parameters["@apellido"].Value = apellidoSelTextBox.Text;
                        modificarCliente.Parameters.Add("@mail", SqlDbType.Char);
                        modificarCliente.Parameters["@mail"].Value = mailSelTextBox.Text;
                        modificarCliente.Parameters.Add("@telefono", SqlDbType.Char);
                        modificarCliente.Parameters["@telefono"].Value = telefonoSelTextBox.Text;
                        modificarCliente.Parameters.Add("@direccion", SqlDbType.Char);
                        modificarCliente.Parameters["@direccion"].Value = direccionSelTextBox.Text;
                        modificarCliente.Parameters.Add("@piso", SqlDbType.Int);
                        modificarCliente.Parameters["@piso"].Value = pisoSelTextBox.Text;
                        modificarCliente.Parameters.Add("@departamento", SqlDbType.Char);
                        modificarCliente.Parameters["@departamento"].Value = departamentoSelTextBox.Text;
                        modificarCliente.Parameters.Add("@localidad", SqlDbType.Char);
                        modificarCliente.Parameters["@localidad"].Value = localidadSelTextBox.Text;
                        modificarCliente.Parameters.Add("@fechaNac", SqlDbType.Date);
                        modificarCliente.Parameters["@fechaNac"].Value = fechaNacimientoSelDatePicker.Text;
                        modificarCliente.Parameters.Add("@habilitado", SqlDbType.Int);
                        modificarCliente.Parameters["@habilitado"].Value = habilitado;
						modificarCliente.Parameters.Add("@codPos", SqlDbType.VarChar);
						modificarCliente.Parameters["@codPos"].Value = this.codigoSelTextBox.Text;

						modificarCliente.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "there was an issue!");
                }
            }
            Conexion.Close();
            this.Close();
        }
    }
}
