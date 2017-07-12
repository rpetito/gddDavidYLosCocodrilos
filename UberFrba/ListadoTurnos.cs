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

namespace UberFrba
{
    public partial class ListadoTurnos : Form
    {
        public ListadoTurnos()
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Agregar";
            checkColumn.HeaderText = "Agregar";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.TrueValue = true;
            checkColumn.FalseValue = false;
            checkColumn.FillWeight = 10;
            this.turnosGrid.Columns.Add(checkColumn);
            fillDataGrid();

        }

        private DataTable fillDataGrid()
        {
            SqlConnection Conexion = BaseDeDatos.ObternerConexion();
            SqlCommand buscarTurno = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                using (buscarTurno = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_TURNOS_HABILITADOS", Conexion))
                {
                    buscarTurno.CommandType = CommandType.StoredProcedure;

                    da.SelectCommand = buscarTurno;
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

        private void agregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.turnosGrid.Rows)
                {
                    Boolean selected = row.Cells[0].Value == null ? false : true;
                    if (selected)
                    {
                        Turno.getInstance().agregarAListaTurnos((Int32)row.Cells[1].Value);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al agregar turno.");
            }

            this.Close();
        }

    }
}
