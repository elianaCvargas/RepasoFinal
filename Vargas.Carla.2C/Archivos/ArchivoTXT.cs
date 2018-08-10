using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Archivos
{
    public class ArchivoTXT: IArchivos<Persona, string>
    {
         private string pathArchivos;

         public ArchivoTXT(string path, int capacidad)
           
        {
            this.pathArchivos = path;
        }

       

        
        #region Escribir formato TXT
        public bool Guardar(Persona elemento, string path)
        {
            try
            {
                
                StreamWriter sw = new StreamWriter( path, true);
                if (elemento is Alumno)
                {
                    
                     sw.WriteLine(elemento.ToString());
                     return true;
                }
                sw.WriteLine(elemento.ToString());
                sw.Close();
                return true;
                

            }
            catch (Exception)
            {

               // throw new ArchivoException("No se pudo guardar");
                return false;

            }
            //return false;
        }
        #endregion
        #region Leer Formato TXT
        //T Leer(String path);
        public string Leer(string path)
        {
            string datosRecibidos = "";
            try
            {
               
                bool fileExist = File.Exists(path);
                
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
                return datosRecibidos = "";
           //    throw new ArchivoException("No se pudo leer");
               

            }
        }
        #endregion
    }
}
