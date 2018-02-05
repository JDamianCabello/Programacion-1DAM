using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_ItinerarForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            MiLista lista = new MiLista();

            foreach(int tmp in lista)
                Console.Write("\t{0}",tmp);

            Console.ReadKey();

        }
    }
}
