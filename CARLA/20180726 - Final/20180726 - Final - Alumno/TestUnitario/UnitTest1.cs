using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using _20180726___Final;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComprobarLecturaYEscritura()
        {
            Sofa sofaEscrito = new Sofa(1, 2, 3, ColorSofa.Blanco);
            ArchivoXML archivo = new ArchivoXML();

            archivo.Guardar("Simulacro.xml", sofaEscrito);

            Sofa sofaLeido = (Sofa)archivo.Leer("Simulacro.xml");
            //Console.WriteLine("sofa 1: {0}, sofa 2 : {1}", sofa.ToString(), sofa2.ToString());
            Assert.AreEqual(sofaEscrito.alto, sofaLeido.alto);
            Assert.AreEqual(sofaEscrito.ancho, sofaLeido.ancho);
            Assert.AreEqual(sofaEscrito.profundidad, sofaLeido.profundidad);
            Assert.AreEqual(sofaEscrito.color, sofaLeido.color);
            
        }
    }
}
