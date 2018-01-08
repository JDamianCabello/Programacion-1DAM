using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian.app_POO_espacioNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo.... desde Damian.app_POO_espacioNombres.Program");
            Holamundo.Escribe();
            Damian.Dos.ClaseDos.Saluda();
            Damian.Tres.ClaseTres.Saluda();
        }
    }

    class Holamundo
    {
        public static void Escribe()
        {
            Console.WriteLine("Hola mundo.... desde Damian.app_POO_espacioNombres.Holamundo");
        }

        public static void Saluda()
        {
            Console.WriteLine("Hola soy la Holamundo, Saluda()");
        }
    }
}

namespace Damian.Dos
{
    public static class ClaseDos
    {
        public static void Saluda()
        {
            Console.WriteLine("Hola soy la ClaseDos, Saluda()");
        }
    }
}

namespace Damian.Tres
{
    public static class ClaseTres
    {
        public static void Saluda()
        {
            Console.WriteLine("Hola soy la ClaseTres, Saluda()");
        }
    }
}
