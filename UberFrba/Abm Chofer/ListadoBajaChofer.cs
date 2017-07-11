﻿using System;
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
    public partial class ListadoBajaChofer : Form
    {
        public ListadoBajaChofer()
        {
            InitializeComponent();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = "Eliminar";
            button.Name = "eliminarButton";
            button.Text = "Eliminar";
            button.UseColumnTextForButtonValue = true;
            choferesGrid.Columns.Add(button);
            button.Frozen = true;
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

        private void choferesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                //tirar un mensaje para confirmar si el usuario esta seguro
                //si selecciona SI
                Decimal dni = (Decimal)choferesGrid.SelectedCells[3].Value;
                SqlConnection Conexion = BaseDeDatos.ObternerConexion();
                SqlCommand eliminarChofer = new SqlCommand();

                try
                {
                    using (eliminarChofer = new SqlCommand("DAVID_Y_LOS_COCODRILOS.INHABILITAR_USUARIO", Conexion))
                    {
                        eliminarChofer.CommandType = CommandType.StoredProcedure;
                        eliminarChofer.Parameters.Add("@dni", SqlDbType.Decimal);
                        eliminarChofer.Parameters["@dni"].Value = dni;
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
