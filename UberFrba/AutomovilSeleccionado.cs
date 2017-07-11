using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class AutomovilSeleccionado
    {
        private String patente;
        private String marca;
        private String modelo;
        private String turno;
        private String chofer;

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

        public String getTurno() {
            return turno;
        }

        public void setTurno(String turno) {
            this.turno = turno;
        }

        public String getChofer() {
            return chofer;
        }

        public void setChofer(String chofer) {
            this.chofer = chofer;
        }
    }
}
