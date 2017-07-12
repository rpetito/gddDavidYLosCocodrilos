using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class Turno
    {
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
