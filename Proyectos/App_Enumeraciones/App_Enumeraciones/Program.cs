using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Enumeraciones
{
    class Program
    {
        enum Dedo { indice, anular, corazon, pulgar, meñique };

        static void Main(string[] args)
        {
            Random rnd = new Random();
            for(int i = 0; i < 10; i++)
                Console.WriteLine((Dedo)rnd.Next(4));

            Console.ReadLine();
        }
    }
}
