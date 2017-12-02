using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero = 0;
            Console.WriteLine("Adivina el número.");
            Console.WriteLine("Introduce el número a que deberá buscar tu compañero.");
            if(byte.TryParse(Console.ReadLine(), out numero))
            {
                
            }
        }
    }
}
