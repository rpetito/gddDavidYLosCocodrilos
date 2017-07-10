using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba
{
    class Rol {

        Int32 id;
        String detalle;

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

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }      

            return getID() == ((Rol)obj).getID();

        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }

    }

}
