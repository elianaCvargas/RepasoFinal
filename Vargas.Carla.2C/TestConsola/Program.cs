using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar Alumno (Nombre, Apellido y  Dni): ");
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string dni = Console.ReadLine();
            Console.WriteLine(name);
            
            Alumno a = new Alumno(name,surname, dni );
            Console.WriteLine(a.ToString());


            Console.ReadKey();

        }
    }
}
