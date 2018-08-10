using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
   public  class ArchivoXML: IArchivos<Persona, Persona>
    {
       public bool Guardar( Persona elemento,string path)
        {
            try
            {
                if (elemento is Alumno)
                {
                    Alumno pA = (Alumno)elemento;
                    XmlTextWriter xw = new XmlTextWriter(path, Encoding.UTF8);
                    XmlSerializer ser = new XmlSerializer(typeof(Alumno));
                    ser.Serialize(xw, pA);
                    xw.Close();
                    return true;

                }
                return false;
            }
            catch (Exception e)
            {
                // throw new ErrorArchivoException("Error al guardar el archivo", e);
                throw e;
            }
        }
        public Persona Leer(string path)
        {
            Docente votacion ;
            try
            {
                //ProductoA votacion = new ProductoA();
                XmlTextReader xTxtReader = new XmlTextReader(path);
                XmlSerializer xs = new XmlSerializer(typeof(Docente));
                votacion = (Docente)xs.Deserialize(xTxtReader);
                xTxtReader.Close();
                return votacion;
            }
            catch (Exception e)
            {
                // throw new ErrorArchivoException("Error al leer el archivo", e);
                throw e;
            }
        }
    }




   class Prueba
   {
       public static void OpTest<T>(T s, T t) where T : class
       {
           System.Console.WriteLine(s == t);
       }

       public void OpTest2<T>(T s, T t) where T : class
       {
           System.Console.WriteLine(s == t);
       }
   }

}
