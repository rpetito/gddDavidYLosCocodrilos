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
    public partial class BuscadorClientes : Form
    {
        public BuscadorClientes()
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
   
            Decimal dni = 0;
            String nombre;
            String apellido;
            String dniNulo;
            try
            {
                if (string.IsNullOrWhiteSpace(dniTextBox.Text))
                {
                    dniNulo = null;
                }
                else
                {
                    dni = Convert.ToDecimal(dniTextBox.Text);
                }

                if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
                {
                    nombre = null;
                }
                else
                {
                    nombre = nombreTextBox.Text;
                }

                if (string.IsNullOrWhiteSpace(apellidoTextBox.Text))
                {
                    apellido = null;
                }
                else
                {
                    apellido = apellidoTextBox.Text;
                }
               
                using (buscarCliente = new SqlCommand("DAVID_Y_LOS_COCODRILOS.BUSCAR_USUARIO", Conexion))
                {
                    buscarCliente.CommandType = CommandType.StoredProcedure;
                    buscarCliente.Parameters.Add("@rol", SqlDbType.Int);
                    buscarCliente.Parameters["@rol"].Value = 2;
                    buscarCliente.Parameters.Add("@nombre", SqlDbType.Char);
                    buscarCliente.Parameters["@nombre"].Value = nombreTextBox.Text;
                    buscarCliente.Parameters.Add("@apellido", SqlDbType.Char);
                    buscarCliente.Parameters["@apellido"].Value = apellidoTextBox.Text;
                    if (string.IsNullOrWhiteSpace(dniTextBox.Text))
                    {
                        buscarCliente.Parameters.Add("@dni", SqlDbType.Char);
                        buscarCliente.Parameters["@dni"].Value = DBNull.Value;
                    }
                    else
                    {
                        buscarCliente.Parameters.Add("@dni", SqlDbType.Decimal);
                        buscarCliente.Parameters["@dni"].Value = dni;
                    }
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
                UsuarioSeleccionado.setInstance();
                UsuarioSeleccionado.getInstance().setNombre(this.clientesGrid.CurrentRow.Cells[1].Value.ToString());
                UsuarioSeleccionado.getInstance().setApellido(this.clientesGrid.CurrentRow.Cells[2].Value.ToString());
                this.Close();
            }
        }
        
    }
}
