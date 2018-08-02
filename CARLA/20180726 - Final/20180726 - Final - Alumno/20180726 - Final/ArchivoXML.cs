
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace _20180726___Final
{
    [Serializable]
    public class ArchivoXML : IArchivos<bool, Asiento>
    {

        public bool Guardar(string path, Asiento elemento)
        {
            try
            {
                if (elemento is Sofa )
                {
                    Sofa pA = (Sofa)elemento;
                    XmlTextWriter xw = new XmlTextWriter(path, Encoding.UTF8);
                    XmlSerializer ser = new XmlSerializer(typeof(Sofa));
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
        public Asiento Leer(string path) 
        {
            Sofa votacion = new Sofa();
            try
            {
                //ProductoA votacion = new ProductoA();
                XmlTextReader xTxtReader = new XmlTextReader(path);
                XmlSerializer xs = new XmlSerializer(typeof(Sofa));
                votacion = (Sofa)xs.Deserialize(xTxtReader);
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
}
