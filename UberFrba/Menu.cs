using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            InitializeComponent();
        }

        private void automovilesButton_Click(object sender, EventArgs e)
        {
            Abm_Automovil.Automovil auto = new Abm_Automovil.Automovil();
            auto.ShowDialog();
        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            Abm_Cliente.Clientes cliente = new Abm_Cliente.Clientes();
            cliente.ShowDialog();
        }

        private void rolesButton_Click(object sender, EventArgs e)
        {
            Abm_Rol.Rol rol = new Abm_Rol.Rol();
            rol.ShowDialog();
        }

        private void choferesButton_Click(object sender, EventArgs e)
        {
            Abm_Chofer.Chofer chofer = new Abm_Chofer.Chofer();
            chofer.ShowDialog();
        }

        private void turnosButton_Click(object sender, EventArgs e)
        {
            Abm_Turno.Turno turno = new Abm_Turno.Turno();
            turno.ShowDialog();
        }

        private void registroButton_Click(object sender, EventArgs e)
        {
            Registro_Viajes.Registro registro = new Registro_Viajes.Registro();
            registro.ShowDialog();
        }

        private void rendicionButton_Click(object sender, EventArgs e)
        {
            Rendicion_Viajes.Rendicion rendicion = new Rendicion_Viajes.Rendicion();
            rendicion.ShowDialog();
        }

        private void facturacionButton_Click(object sender, EventArgs e)
        {
            Facturacion.Facturacion facturacion = new Facturacion.Facturacion();
            facturacion.ShowDialog();
        }

        private void administradoresButton_Click(object sender, EventArgs e)
        {
            Administrador.Administrador admin = new Administrador.Administrador();
            admin.ShowDialog();
        }

        private void estadisticosButton_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.Form1 estadisticas = new Listado_Estadistico.Form1();
            estadisticas.ShowDialog();
        }
    }
}
