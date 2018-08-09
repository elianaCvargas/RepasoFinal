using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAlmaceable<T, V>
    {
        bool Guardar(V elemento);
        T Leer(String path);
    }
}
