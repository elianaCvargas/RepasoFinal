using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // Redefinir ToString para que retorne la información del Asiento de forma ordenada. Utilizar string.Format o StringBuilder.
    // Utilizar la teoría de encapsulamiento en todas las clases.
    // La clase debe ser abstracta
    // Crear un método abstracto llamado ProbarAsiento que retorne un bool.
    public abstract class Asiento
    {
        public short alto;
        public short ancho;
        public short profundidad;

        public Asiento()
        { }
        public Asiento(short alto, short ancho, short profundidad)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
        }

        public override string ToString()
        {
             return string.Format("Alto: {0}, Ancho: {1}, Profundidad: {2}, ", this.alto.ToString(), this.ancho.ToString(), this.profundidad.ToString());
        }

        public abstract void ProbarAsiento();

        // Este método invocará al evento que se nombra a continuación. 
        public void InformarFinDePrueba(bool param)
        {   //esto es invocar el evento
            FinPruebaCalidad.Invoke(param);
        }

        #region Events

        public delegate void PruebaCalidad(bool param);
        
        public event PruebaCalidad FinPruebaCalidad;
        #endregion
    
       
    }
}
