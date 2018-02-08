using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------
using Damian.App_POO_IComparable_ICompare;

namespace App_PruebaDLL_Persona
{
    class Program
    {
        static List<Persona> personas = new List<Persona>();

        static void Main(string[] args)
        {
            CrearVariasPersonas();
            Console.WriteLine(" LISTA SIN ORDENAR");
            Listar(); //Sin ordenar

            personas.Sort();
            Console.WriteLine("LISTA ORDENADA");
            Listar();

            personas.Sort(new Persona.OrdenarApellidos());
            Console.WriteLine("LISTA ORDENADA POR APELLIDO");
            Listar();

            personas.Sort(new Persona.OrdenarNombre());
            Console.WriteLine("LISTA ORDENADA POR NOMBRE");
            Listar();
        }

        static void CrearVariasPersonas()
        {
            personas.Add(new Persona("Miguel", "Javier", 100));
            personas.Add(new Persona("Fernández", "Edu", 150));
            personas.Add(new Persona("Muñoz", "Adrián", 125));
            personas.Add(new Persona("Cabello", "Damián", 200));
            personas.Add(new Persona("Miguel", "David", 110));
        }

        static void Listar()
        {
            foreach(Persona tmp in personas)
                Console.WriteLine(tmp);
            Console.WriteLine("\nFIN DEL LISTADO... ");
            Console.ReadLine();
        }
    }
}
