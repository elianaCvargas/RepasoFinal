using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    

    // Agregar un enumerado con los colores: Natural, Blanco, Negro, Rojo. Utilizar este enumerado en el atributo color de Sofa.
    // Generar una relación de herencia entre Asiento y Sofa.
    // Modificar los atributos y constructores según crea necesario.
    // El método ProbarAsiento hará un Sleep de 3 segundos y retornará true o false de forma aleatoria (Random).

    // Utilizar la teoría de encapsulamiento en todas las clases.
   public enum ColorSofa
   {
            Natural,
            Blanco,
            Negro,
            Rojo,
   }
    public class Sofa : Asiento
    {

        public ColorSofa color;
        public Sofa()
        { }

        private Sofa(short alto, short ancho, short profundidad)
            : base(alto, ancho, profundidad)
        {

        }

        public Sofa(short alto, short ancho, short profundidad, ColorSofa color)
            : base(alto, ancho, profundidad)
        {
            this.color = color;
        }

   

        public override string ToString()
        {
            StringBuilder mysb = new StringBuilder();
            mysb.AppendLine(  base.ToString() + this.color.ToString());
            return mysb.ToString();
        }

        public override void ProbarAsiento() 
        {
            bool aux = true;
            Random random = new Random();
            
            int num = random.Next(0, 1);
            //if (num > 0)
            //{
                Thread.Sleep(5000);
                base.InformarFinDePrueba(aux);
                aux = false;
            //}       
          
        }
        
    }
}
