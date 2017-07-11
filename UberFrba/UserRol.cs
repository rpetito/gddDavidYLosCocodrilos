using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba {

	class UserRol {

		private Int32 id;
		private String detalle;

		public void setID(Int32 id) {
			this.id = id;
		}

		public void setDetalle(String detalle) {
			this.detalle = detalle;
		}

		public Int32 getID() {
			return this.id;
		}

		public String getDetalle() {
			return this.detalle;
		}


		 // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }      

            return getID() == ((UserRol)obj).getID();

        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }

	
	


}
