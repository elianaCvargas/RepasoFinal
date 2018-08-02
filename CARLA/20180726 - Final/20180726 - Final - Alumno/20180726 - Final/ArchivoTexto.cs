using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace _20180726___Final
{
    public class ArchivoTexto : IArchivos<bool, string>
    {
     
        #region Escribir formato TXT
        public bool Guardar(string path, string elemento)
        {
            try
            {
                //obtenemos el path del directorio al cual queremos guardar
                //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + nombreArchivo;
                //bool fileExist = File.Exists(path);
                //if (!fileExist)
                //{
                StreamWriter sw = new StreamWriter(path, true);//esto ya verifica si el archivo existe, si existe agrega los datos, sino lo crea.
                //string text = string.Format("{0}", textoAEscribir);
                sw.WriteLine(elemento);
                sw.Close();
                return true;
                //}

            }
            catch (Exception ex)
            {

                throw new ArchivoExcepciones("No se pudo guardar");

            }
            //return false;
        }
        #endregion
        #region Leer Formato TXT
        public string Leer(string path)
        {
            string datosRecibidos = "";
            try
            {
                //string secuenciaMasNombreTexto = string.Format("\x5c{0}", nombreArchivo);

                //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + secuenciaMasNombreTexto;
                //string pathReal = "C:\nUsers\nCarlaEliana\nDesktop\nArchivoTxt";
                bool fileExist = File.Exists(path);
                //fileexist da true porque el archvo esta en el directorio por defecto
                if (fileExist)
                {
                    StreamReader file = new StreamReader(path);
                    datosRecibidos = file.ReadToEnd();
                    file.Close();
                    return datosRecibidos;

                }
                datosRecibidos = "";
                
                return datosRecibidos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                datosRecibidos = "";
                throw new ArchivoExcepciones("No se pudo leer");
                

            }
        }
        #endregion
    }
}
