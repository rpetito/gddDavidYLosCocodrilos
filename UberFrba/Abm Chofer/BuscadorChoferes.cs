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
    public partial class BuscadorChoferes : Form
    {
        public BuscadorChoferes()
        {
            InitializeComponent();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Seleccionar";
            button.Name = "seleccionarButton";
            button.Text = "Seleccionar";
            button.UseColumnTextForButtonValue = true;
            choferesGrid.Columns.Add(button);
            button.Frozen = true;
        }
		
        private void limpiarButton_Click(object sender, EventArgs e)
        {
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            dniTextBox.Clear();
            choferesGrid.ClearSelection();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            getChoferes();
        }

        private DataTable getChoferes()
        {
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand buscarChofer = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            Decimal dni = 0;
            String nombre;
            String apellido;
            String dniNulo = null;

            try
            {
                if (string.IsNullOrWhiteSpace(dniTextBox.Text))
                {
                     dniNulo = null;
                }
                else
                {
                    dni = Convert.ToDecimal( dniTextBox.Text);
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
                using (buscarChofer = new SqlCommand("DAVID_Y_LOS_COCODRILOS.BUSCAR_USUARIO", Conexion))
                {
                    buscarChofer.CommandType = CommandType.StoredProcedure;
                   // buscarChofer.Parameters.Add("@rol", SqlDbType.Int);
                  //  buscarChofer.Parameters["@rol"].Value = 3;
                    buscarChofer.Parameters.Add("@nombre", SqlDbType.Char);
                    buscarChofer.Parameters["@nombre"].Value = (object)nombre ?? DBNull.Value;
                    buscarChofer.Parameters.Add("@apellido", SqlDbType.Char);
                    buscarChofer.Parameters["@apellido"].Value = (object)apellido ?? DBNull.Value;
                    if (string.IsNullOrWhiteSpace(dniTextBox.Text))
                    {
                        buscarChofer.Parameters.Add("@dni", SqlDbType.Char);
                        buscarChofer.Parameters["@dni"].Value = DBNull.Value;
                    }
                    else
                    {
                        buscarChofer.Parameters.Add("@dni", SqlDbType.Decimal);
                        buscarChofer.Parameters["@dni"].Value = dni;
                    }
                    da.SelectCommand = buscarChofer;
                    da.Fill(dt);
                    choferesGrid.DataSource = dt;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }
            Conexion.Close();
            return dt;

        }

        private void choferesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                UsuarioSeleccionado.setInstance();
                UsuarioSeleccionado.getInstance().setDni(Convert.ToDecimal( this.choferesGrid.CurrentRow.Cells[3].Value));
                UsuarioSeleccionado.getInstance().setNombre(this.choferesGrid.CurrentRow.Cells[1].Value.ToString());
                UsuarioSeleccionado.getInstance().setApellido(this.choferesGrid.CurrentRow.Cells[2].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
