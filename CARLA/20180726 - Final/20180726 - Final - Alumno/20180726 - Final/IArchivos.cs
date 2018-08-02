using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180726___Final
{
    public interface IArchivos<V, T>
    {
        V Guardar(string path, T elemento);
        T Leer(string path);
    }
}
