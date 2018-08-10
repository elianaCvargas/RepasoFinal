using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente: Persona
    {
        public string legajo;

        
        public Docente(string nombre, string apellido, string legajo)
           :base(nombre, apellido)
        {
            this.legajo = legajo;
        }
        public string Legajo { 
            get { 
            return this.legajo;  
        } 
            
        }

        protected override string Mostrar()
        {
            return string.Format("{0} Legajo: {1}", base.Mostrar(), this.legajo);
        }

        public static explicit operator string(Docente d)
        {
            return d.Mostrar();
        }

        public void Calificar()
        {
            Thread.Sleep(2000);
            int ran;
            Random random = new Random();
            ran = random.Next();
        }
    }
}
