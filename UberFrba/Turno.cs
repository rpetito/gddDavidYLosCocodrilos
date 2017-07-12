using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class Turno
    {
        Int32 id;
        String detalle;
        Boolean habilitado;


        public Int32 getID()
        {
            return id;
        }

        public String getDetalle()
        {
            return detalle;
        }

        public void setID(Int32 id)
        {
            this.id = id;
        }

        public void setDetalle(String detalle)
        {
            this.detalle = detalle;
        }

        public void setHabilitado(Int32 habilitado)
        {
            this.habilitado = habilitado == 1;
        }

        public void setHabilitado(Boolean habilitado)
        {
            this.habilitado = habilitado;
        }

        public Boolean getHabilitado()
        {
            return this.habilitado;
        }

        public static Turno instance = null;
        private List<Int32> listaTurnos = new List<Int32>();

        public static Turno getInstance()
        {
            if (instance == null)
            {
                instance = new Turno();
            }

            return instance;
        }

        public static void setInstance() {
            instance = null;
        }

        public void agregarAListaTurnos(Int32 turno) {
            listaTurnos.Add(turno);
        }
        public List<Int32> getListaTurnos() {
            return listaTurnos;
        }
    }
}
