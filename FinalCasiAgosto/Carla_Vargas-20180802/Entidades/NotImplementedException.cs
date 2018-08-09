using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class NotImplementedException: Exception
    {
         
        public NotImplementedException(string mensaje, Exception inner)
            :base(mensaje, inner)
        {

        }
        public NotImplementedException(string mensaje)
            :this(mensaje,null)
        {

        }
    }
}
