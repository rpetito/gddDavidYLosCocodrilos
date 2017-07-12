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
    public partial class Menu : Form
    {


        public Menu()
        {
			GetFunctionalities();
        }


		private void GetFunctionalities() {

			SqlConnection Conexion = BaseDeDatos.ObternerConexion();
			SqlCommand getFunctionalities = new SqlCommand();
			SqlDataReader result;

			using( getFunctionalities = new SqlCommand("DAVID_Y_LOS_COCODRILOS.OBTENER_FUNCIONES_HABILITADAS_PARA_ROL", Conexion) ) {

				getFunctionalities.CommandType = CommandType.StoredProcedure;
				getFunctionalities.Parameters.Add("@rol", SqlDbType.Int);
				getFunctionalities.Parameters["@rol"].Value = Usuario.getInstance().getRolSeleccionado().getID();

			}


			result = getFunctionalities.ExecuteReader();

			FlowLayoutPanel panel = new FlowLayoutPanel();
			panel.FlowDirection = FlowDirection.LeftToRight;
			panel.AutoScroll = true;
			panel.WrapContents = true;
			panel.Width = 500;
			panel.Height = 500;
			this.Controls.Add(panel);

			while( result.Read() ) {

				if( result.VisibleFieldCount == 2 ) {

					Button button = new Button();

					button.Tag = result.GetInt32(0);
					button.Text = result.GetString(1);
					button.Width = 250;
					button.Click += button_Click;
					
					panel.Controls.Add(button);

				} else {
					MessageBox.Show("Error", "Algo ha ocurrido, por favor vuelve a intentarlo.");
				}
			
			}


		}


		void button_Click(object sender, EventArgs e) {
			Form view = MenuController.getViewForFunctionality(Convert.ToInt32(((Button)sender).Tag));
			view.ShowDialog();
		}


    }




}
