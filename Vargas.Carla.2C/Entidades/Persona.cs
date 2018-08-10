using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;

        public Persona(string nombre, string apellido)

        {
            this.nombre = nombre;
            this.apellido = apellido;

        }
        public Persona(string nombre, string apellido, string dni)
            :this(nombre, apellido)
        {
            this.dni = DNI;
        }


        public string DNI {
            get { return this.dni; }
            set {
                try
                {
                    int dni;
                     bool isNumero = int.TryParse(value, out dni);
                     if (isNumero)
                     {
                         this.dni = value;
                     }
                }
                catch (Exception)
                {
                    
                    throw new DniExcepcion("Debe ingresar solo numeros");
                }
            }
        }

        protected virtual string Mostrar()
        {
            return string.Format("Nombre: {0}, Apellido: {1}, DNI: {2}\n", nombre, apellido,  dni);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int ValidarNumero(string numero)
        {
            //            ValidarNumero comprobará que el valor recibido sea numérico, y lo retornará en
            //            formato double. Caso contrario, retornará 0.
            int dni = 0;
            bool isNumero = int.TryParse(numero, out dni);
            
            if (isNumero)
            {
                return dni;
            }
            else return dni;
        }

    }
}
