using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
     
        public Alumno(string nombre, string apellido,string dni)
            :base(nombre, apellido, dni)
        {
        
        }

        protected override string Mostrar()
        {
            return base.Mostrar();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (a1.DNI == a2.DNI)            
                return true;
            return false;

        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

      

    }
}
