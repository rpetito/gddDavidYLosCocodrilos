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
    public partial class ListadoModCliente : Form
    {
        public ListadoModCliente()
        {
            InitializeComponent();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Seleccionar";
            button.Name = "seleccionarButton";
            button.Text = "Seleccionar";
            button.UseColumnTextForButtonValue = true;
            clientesGrid.Columns.Add(button);
            button.Frozen = true;
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            dniTextBox.Clear();
            clientesGrid.ClearSelection();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            getClientes();
        }

        private DataTable getClientes()
        {
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand buscarCliente = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            String dni;
            try
            {
                if (string.IsNullOrWhiteSpace(dniTextBox.Text))
                {
                    dni = null;
                }
                else dni = dniTextBox.Text;


                using (buscarCliente = new SqlCommand("DAVID_Y_LOS_COCODRILOS.BUSCAR_USUARIO", Conexion))
                {
                    buscarCliente.CommandType = CommandType.StoredProcedure;
                    buscarCliente.Parameters.Add("@nombre", SqlDbType.Char);
                    buscarCliente.Parameters["@nombre"].Value = nombreTextBox.Text;
                    buscarCliente.Parameters.Add("@apellido", SqlDbType.Char);
                    buscarCliente.Parameters["@apellido"].Value = apellidoTextBox.Text;
                    buscarCliente.Parameters.Add("@dni", SqlDbType.Decimal);
                    buscarCliente.Parameters["@dni"].Value = dni;
                    da.SelectCommand = buscarCliente;
                    da.Fill(dt);
                    clientesGrid.DataSource = dt;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }
            Conexion.Close();
            return dt;

        }

        private void clientesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                UsuarioSeleccionado.getInstance().setNombre(this.clientesGrid.CurrentRow.Cells[1].Value.ToString());
                UsuarioSeleccionado.getInstance().setApellido(this.clientesGrid.CurrentRow.Cells[2].Value.ToString());
                UsuarioSeleccionado.getInstance().setDni((Decimal)this.clientesGrid.CurrentRow.Cells[3].Value);
                UsuarioSeleccionado.getInstance().setMail(this.clientesGrid.CurrentRow.Cells[4].Value.ToString());
                UsuarioSeleccionado.getInstance().setTelefono(this.clientesGrid.CurrentRow.Cells[5].Value.ToString());
                UsuarioSeleccionado.getInstance().setDireccion(this.clientesGrid.CurrentRow.Cells[6].Value.ToString());

                if (string.IsNullOrWhiteSpace(this.clientesGrid.CurrentRow.Cells[7].Value.ToString()))
                    UsuarioSeleccionado.getInstance().setPiso(0);
                else UsuarioSeleccionado.getInstance().setPiso((Int32)this.clientesGrid.CurrentRow.Cells[7].Value);

                if (string.IsNullOrWhiteSpace(this.clientesGrid.CurrentRow.Cells[8].Value.ToString()))
                    UsuarioSeleccionado.getInstance().setDepartamento("-");
                else UsuarioSeleccionado.getInstance().setDepartamento(this.clientesGrid.CurrentRow.Cells[8].Value.ToString());

                UsuarioSeleccionado.getInstance().setLocalidad(this.clientesGrid.CurrentRow.Cells[9].Value.ToString());
                UsuarioSeleccionado.getInstance().setCodigoPostal(this.clientesGrid.CurrentRow.Cells[10].Value.ToString());
                UsuarioSeleccionado.getInstance().setFechaNacimiento((DateTime)this.clientesGrid.CurrentRow.Cells[11].Value);
                UsuarioSeleccionado.getInstance().setHabilitado((Int32)this.clientesGrid.CurrentRow.Cells[15].Value);
                
                FormularioModCliente form = new FormularioModCliente();
                form.ShowDialog();
            }
        }


    }
}
