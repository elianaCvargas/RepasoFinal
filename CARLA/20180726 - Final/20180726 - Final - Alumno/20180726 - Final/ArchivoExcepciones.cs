using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180726___Final
{
    public class ArchivoExcepciones: Exception
    {
        public ArchivoExcepciones(string mensaje, Exception inner)
            :base(mensaje, inner)
        {

        }
        public ArchivoExcepciones(string mensaje)
            :this(mensaje,null)
        {

        }
    }
}
