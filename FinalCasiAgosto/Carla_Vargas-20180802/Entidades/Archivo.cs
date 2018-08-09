using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Sobreescribir el método ToString para mostrar los valores de sus atributos.Utilizar String.Format.
    
    public class Archivo
    {
        private string nombre;
        private string contenido;

        public Archivo(string nombre, string contenido)
        {
            this.nombre = nombre;
            this.contenido = contenido;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Contenido: {1}.", this.nombre, this.contenido);
        }

        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; } 
        }
        public string Contenido {
            get { return this.contenido; }
            set { this.contenido = value; }
        }

        public static explicit operator string(Archivo a)
        {
            return a.ToString();
        }
    }
}
