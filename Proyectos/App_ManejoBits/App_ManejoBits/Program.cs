using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ManejoBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15; //1111 -> 0000 000
            int y = 0;

            Console.WriteLine("El valor de x -> {0:X8}",x);
            y = x >> 1;
            Console.WriteLine("x >> 1 -> {0:X8}",y);

            x = 12;
            y = 7;

            Console.WriteLine("El valor de x & y -> {0:X8}", x & y);
            Console.WriteLine("El valor de x | y -> {0:X8}", x | y);
            Console.WriteLine("El valor de x ^ y -> {0:X8}", x ^ y);
            Console.ReadKey();
        }
    }
}
