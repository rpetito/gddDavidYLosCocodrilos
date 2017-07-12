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
    public partial class FormularioModChofer : Form
    {
        public FormularioModChofer()
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
            mailSelTextBox.Clear();
            habilitadoCheckBox.Checked = false;
        }

        private void modificarSelButton_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand modificarChofer = new SqlCommand();

            if (string.IsNullOrWhiteSpace(nombreSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(apellidoSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(fechaNacimientoSelDatePicker.Text)
                    | string.IsNullOrWhiteSpace(telefonoSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(direccionSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(pisoSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(departamentoSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(localidadSelTextBox.Text)
                    | string.IsNullOrWhiteSpace(mailSelTextBox.Text))
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

                    using (modificarChofer = new SqlCommand("DAVID_Y_LOS_COCODRILOS.MODIFICAR_USUARIO", Conexion))
                    {
                        modificarChofer.CommandType = CommandType.StoredProcedure;
						modificarChofer.Parameters.Add("@rol", SqlDbType.Int);
						modificarChofer.Parameters["@rol"].Value = 3;
						modificarChofer.Parameters.Add("@dni", SqlDbType.Decimal);
						modificarChofer.Parameters["@dni"].Value = Convert.ToDecimal(dniSelTextBox.Text);
                        modificarChofer.Parameters.Add("@nombre", SqlDbType.Char);
                        modificarChofer.Parameters["@nombre"].Value = nombreSelTextBox.Text;
                        modificarChofer.Parameters.Add("@apellido", SqlDbType.Char);
                        modificarChofer.Parameters["@apellido"].Value = apellidoSelTextBox.Text;
                        modificarChofer.Parameters.Add("@mail", SqlDbType.Char);
                        modificarChofer.Parameters["@mail"].Value = mailSelTextBox.Text;
                        modificarChofer.Parameters.Add("@telefono", SqlDbType.Char);
                        modificarChofer.Parameters["@telefono"].Value = telefonoSelTextBox.Text;
                        modificarChofer.Parameters.Add("@direccion", SqlDbType.Char);
                        modificarChofer.Parameters["@direccion"].Value = direccionSelTextBox.Text;
                        modificarChofer.Parameters.Add("@piso", SqlDbType.Int);
                        modificarChofer.Parameters["@piso"].Value = pisoSelTextBox.Text;
                        modificarChofer.Parameters.Add("@departamento", SqlDbType.Char);
                        modificarChofer.Parameters["@departamento"].Value = departamentoSelTextBox.Text;
                        modificarChofer.Parameters.Add("@localidad", SqlDbType.Char);
                        modificarChofer.Parameters["@localidad"].Value = localidadSelTextBox.Text;
                        modificarChofer.Parameters.Add("@fechaNac", SqlDbType.Date);
                        modificarChofer.Parameters["@fechaNac"].Value = fechaNacimientoSelDatePicker.Text;
                        modificarChofer.Parameters.Add("@habilitado", SqlDbType.Int);
                        modificarChofer.Parameters["@habilitado"].Value = habilitado;
						modificarChofer.Parameters.Add("@codPos", SqlDbType.VarChar);
						modificarChofer.Parameters["@codPos"].Value = "";
                    }

					modificarChofer.ExecuteScalar();
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
