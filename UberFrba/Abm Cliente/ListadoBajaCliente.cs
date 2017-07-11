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
    public partial class ListadoBajaCliente : Form
    {
        public ListadoBajaCliente()
        {
            InitializeComponent();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Eliminar";
            button.Name = "eliminarButton";
            button.Text = "Eliminar";
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
                //tirar un mensaje para confirmar si el usuario esta seguro
                //si selecciona SI
                Decimal dni = (Decimal) clientesGrid.SelectedCells[3].Value;
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                SqlCommand eliminarCliente = new SqlCommand();

                try
                {
                    using (eliminarCliente = new SqlCommand("DAVID_Y_LOS_COCODRILOS.INHABILITAR_USUARIO", Conexion))
                    {
                        eliminarCliente.CommandType = CommandType.StoredProcedure;
                        eliminarCliente.Parameters.Add("@dni", SqlDbType.Char);
                        eliminarCliente.Parameters["@dni"].Value = dni;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "there was an issue!");

                }
                Conexion.Close();
            }
        }
    }
}
