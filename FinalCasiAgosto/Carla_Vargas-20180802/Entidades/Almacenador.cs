using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   //Crear un constructor que reciba y asigne el/los atributos de la misma.
   //La clase debe ser abstracta.
    //Crear un método abstracto llamado MostrarArchivos que retorne void.
    //NO SE PUEDE INSTANCIAR UNA CLASE ABSTRACTAAAAAAAAAAAAAAAAAAAA
    public abstract class Almacenador
    {
        public int capacidad;

        public Almacenador(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public abstract void MostrarArchivos();

        #region Events

        public delegate void ProductoTerminado(string texto);
        public event ProductoTerminado MostrarInfo;
        #endregion

        public void DispararEvento(Archivo ar)
        {
            this.MostrarInfo.Invoke(ar.ToString());
        }
    }
}
