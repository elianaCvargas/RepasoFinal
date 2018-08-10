using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DniExcepcion:Exception
    {
         public DniExcepcion(string mensaje, Exception inner)
            :base(mensaje, inner)
        {

        }
         public DniExcepcion(string mensaje)
            :this(mensaje,null)
        {

        }
    }
}
