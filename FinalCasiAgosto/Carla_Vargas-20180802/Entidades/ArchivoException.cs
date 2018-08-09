using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class ArchivoException: Exception
    {
         public ArchivoException(string mensaje, Exception inner)
            :base(mensaje, inner)
        {

        }
         public ArchivoException(string mensaje)
            :this(mensaje,null)
        {

        }
    }
}
