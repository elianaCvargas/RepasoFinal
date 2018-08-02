using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // Sin modificar Namespace, hacer los cambios necesarios para que todo lo siguiente funcione.
    // AsientoEstandar no podrá ser heredable, o sea que otra clase no podrá heredar de ella.
    // Los atributos ancho, alto y profundidad (todos short) de AsientoEstandar deberá ser accesible sin necesidad de generar una instancia.
    // Dentro del constructor de se le deberá asignar valor 100 a todos los atributos.
    public sealed class AsientoEstandar
    {
        public static short ancho;
        public static short alto;
        public static short profundidad;

        static AsientoEstandar()
        {
            AsientoEstandar.ancho = 100;
            AsientoEstandar.alto = 100;
            AsientoEstandar.profundidad = 100;
        }
    }
}
