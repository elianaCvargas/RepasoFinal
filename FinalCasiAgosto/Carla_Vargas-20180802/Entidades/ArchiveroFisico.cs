using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Deberá heredar de Almacenador e implementar IAlmacenable.
    //Crear un constructor que reciba y asigne el/los atributos de la misma.
    //El método MostrarArchivos lanzará una excepción del tipo NotImplementedException.
    //El método Guardar deberá guardar un objeto de tipo archivo en un archivo de texto en la ubicación definida en el atributo pathArchivos.
    //El método Leer recibirá el nombre de un archivo y deberá retornar su contenido.
    //Tanto en Leer como en Guardar capturar y relanzar las excepciones.
    public class ArchiveroFisico: Almacenador, IAlmaceable<string, Archivo>
    {
        private string pathArchivos;
       
        public ArchiveroFisico( string path, int capacidad)
            :base(capacidad)
        {
            this.pathArchivos = path;
        }

        public override void MostrarArchivos()
        {
 	       throw new NotImplementedException("No se puede mostrar");
        }

        //bool Guardar(V elemento);
        
        #region Escribir formato TXT
        public bool Guardar(Archivo elemento)
        {
            try
            {
                string path = string.Format("{0}", this.pathArchivos);

                StreamWriter sw = new StreamWriter( path, true);//esto ya verifica si el archivo existe, si existe agrega los datos, sino lo crea.
                
                sw.WriteLine(elemento.ToString());
                sw.Close();
                return true;
                

            }
            catch (Exception)
            {

                throw new ArchivoException("No se pudo guardar");
               

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
                datosRecibidos = "";
               throw new ArchivoException("No se pudo leer");
               

            }
        }
        #endregion
    }
}
