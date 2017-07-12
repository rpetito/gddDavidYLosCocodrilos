using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UberFrba.Abm_Turno
{
    public partial class ListadoBajaTurno : Form
    {
        public ListadoBajaTurno()
        {
            InitializeComponent();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            descripcionTextBox.Clear();
            turnosGrid.ClearSelection();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            getTurnos();
        }

        private DataTable getTurnos()
        {
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand obtenerTurnos = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            String descripcion;

            try
            {
               
                if (string.IsNullOrWhiteSpace(descripcionTextBox.Text))
                {
                    descripcion = null;
                }
                else
                {
                    descripcion = descripcionTextBox.Text;
                }

                using (obtenerTurnos = new SqlCommand("DAVID_Y_LOS_COCODRILOS.Obtener_turnos_habilitados", Conexion))
                {
                    obtenerTurnos.CommandType = CommandType.StoredProcedure;

                    obtenerTurnos.Parameters.Add("@DESCRIPCION", SqlDbType.Char);
                    obtenerTurnos.Parameters["@DESCRIPCION"].Value = (object)descripcion ?? DBNull.Value;

                   
                    da.SelectCommand = obtenerTurnos;
                    da.Fill(dt);
                    turnosGrid.DataSource = dt;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "there was an issue!");

            }
            Conexion.Close();
            return dt;

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            
            Int32 selectedTurno = (Int32)turnosGrid.SelectedCells[0].Value;
            SqlConnection sqlConnection = BaseDeDatos.ObternerConexion();
            SqlCommand removeRol = null;

            using (removeRol = new SqlCommand("DAVID_Y_LOS_COCODRILOS.INHABILITAR_TURNO", sqlConnection))
            {

                removeRol.CommandType = CommandType.StoredProcedure;
                removeRol.Parameters.Add("@ID", SqlDbType.Int);
                removeRol.Parameters["@ID"].Value = selectedTurno;

            }


            try
            {
                removeRol.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            this.Close();
        }
    }
}
