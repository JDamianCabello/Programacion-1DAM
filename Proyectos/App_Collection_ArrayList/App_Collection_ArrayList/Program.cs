using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------
//Importante añadir los using´s.
using System.Collections;

namespace App_Collection_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.Add("Damian");
            lista.Add(125);

            MostrarLista(lista);
        }

        static void MostrarLista(ArrayList lista)
        {
            foreach(Object tmp in lista)
                Console.WriteLine(tmp);

            Console.WriteLine("\n\nFin del listado....");
            Console.ReadKey();
        }
    }
}
