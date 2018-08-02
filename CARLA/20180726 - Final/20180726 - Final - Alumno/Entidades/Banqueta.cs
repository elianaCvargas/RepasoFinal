using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // Primer parcial:
    // Agregar un enumerado con los tipos de banqueta: Caño, Madera, Hierro. Utilizar este enumerado en el atributo tipo de Banqueta.
    // Generar una relación de herencia entre Asiento y Sofa.
    // Modificar los atributos y constructores según crea necesario.
    // Primer parcial: sobrecargar el == para que dos banquetas sean iguales sólo si tienen el mismo tipo.

    // Utilizar la teoría de encapsulamiento en todas las clases.
    class Banqueta
    {
        public short alto;
        public short ancho;
        public short profundidad;
        public bool apoyaPies;
        public string tipo;

        private Banqueta(short alto, short ancho, short profundidad)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
        }

        public Banqueta(short alto, short ancho, short profundidad, bool apoyaPies)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
            this.apoyaPies = apoyaPies;
            this.tipo = "Caño";
        }

        public Banqueta(short alto, short ancho, short profundidad, bool apoyaPies, string tipo)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
            this.apoyaPies = apoyaPies;
            this.tipo = tipo;
        }

    }
}
