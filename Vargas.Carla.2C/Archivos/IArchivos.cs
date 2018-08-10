using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivos<T, V>
    {
        bool Guardar(T elemento, string path);
        V Leer(string path);

    }
}
