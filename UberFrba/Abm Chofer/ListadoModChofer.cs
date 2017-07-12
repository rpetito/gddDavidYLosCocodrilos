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
    public partial class ListadoModChofer : Form
    {
        public ListadoModChofer()
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

        private void choferesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                UsuarioSeleccionado.getInstance().setNombre(this.choferesGrid.CurrentRow.Cells[1].Value.ToString());
                UsuarioSeleccionado.getInstance().setApellido(this.choferesGrid.CurrentRow.Cells[2].Value.ToString());
                UsuarioSeleccionado.getInstance().setDni((Decimal)this.choferesGrid.CurrentRow.Cells[3].Value);
                UsuarioSeleccionado.getInstance().setMail(this.choferesGrid.CurrentRow.Cells[4].Value.ToString());
                UsuarioSeleccionado.getInstance().setTelefono(this.choferesGrid.CurrentRow.Cells[5].Value.ToString());
                UsuarioSeleccionado.getInstance().setDireccion(this.choferesGrid.CurrentRow.Cells[6].Value.ToString());

                if(string.IsNullOrWhiteSpace(this.choferesGrid.CurrentRow.Cells[7].Value.ToString()))
                    UsuarioSeleccionado.getInstance().setPiso(0);
                else UsuarioSeleccionado.getInstance().setPiso((Int32)this.choferesGrid.CurrentRow.Cells[7].Value);

                if (string.IsNullOrWhiteSpace(this.choferesGrid.CurrentRow.Cells[8].Value.ToString()))
                    UsuarioSeleccionado.getInstance().setDepartamento("-");
                else UsuarioSeleccionado.getInstance().setDepartamento(this.choferesGrid.CurrentRow.Cells[8].Value.ToString());

                UsuarioSeleccionado.getInstance().setLocalidad(this.choferesGrid.CurrentRow.Cells[9].Value.ToString());
                UsuarioSeleccionado.getInstance().setFechaNacimiento((DateTime)this.choferesGrid.CurrentRow.Cells[11].Value);
                UsuarioSeleccionado.getInstance().setHabilitado((Int32)this.choferesGrid.CurrentRow.Cells[15].Value);
                
                FormularioModChofer form = new FormularioModChofer();
                form.ShowDialog();
            }
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
            String dni;
            try
            {
                if (string.IsNullOrWhiteSpace(dniTextBox.Text))
                {
                    dni = null;
                }
                else dni = dniTextBox.Text;
                

                using (buscarChofer = new SqlCommand("DAVID_Y_LOS_COCODRILOS.BUSCAR_USUARIO", Conexion))
                {
                    buscarChofer.CommandType = CommandType.StoredProcedure;
                    buscarChofer.Parameters.Add("@nombre", SqlDbType.Char);
                    buscarChofer.Parameters["@nombre"].Value = nombreTextBox.Text;
                    buscarChofer.Parameters.Add("@apellido", SqlDbType.Char);
                    buscarChofer.Parameters["@apellido"].Value = apellidoTextBox.Text;
                    buscarChofer.Parameters.Add("@dni", SqlDbType.Decimal);
                    buscarChofer.Parameters["@dni"].Value = dni;
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
    }
}
