using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class AutomovilSeleccionado
    {
        public static AutomovilSeleccionado instance = null;
        private String patente;
        private String marca;
        private String modelo;
        private Int32 turno;
        private Decimal chofer;
        private Int32 habilitado;

        public static AutomovilSeleccionado getInstance()
        {
            if (instance == null)
            {
                instance = new AutomovilSeleccionado();
            }

            return instance;
        }

        public static void setInstance()
        {
            instance = null;
        }

        public String getPatente() {
            return patente;
        }

        public void setPatente(String patente) {
            this.patente = patente;
        }

        public String getMarca() {
            return marca;
        }

        public void setMarca(String marca) {
            this.marca = marca;
        }

        public String getModelo() {
            return modelo;
        }

        public void setModelo(String modelo) {
            this.modelo = modelo;
        }

        public Int32 getTurno() {
            return turno;
        }

        public void setTurno(Int32 turno) {
            this.turno = turno;
        }

        public Decimal getChofer() {
            return chofer;
        }

        public void setChofer(Decimal chofer) {
            this.chofer = chofer;
        }

        public Int32 getHabilitado() {
            return habilitado;
        }

        public void setHabilitado(Int32 habilitado) {
            this.habilitado = habilitado;
        }
    }
}
