using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer17
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNum, segunNum, tercerNum;
            Console.WriteLine("Porgrama que determina si dado tres numeros alguna suma de dos de ellos es el tercero.");
            Console.Write("Introduce el primer número: ");
            primerNum = int.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            segunNum = int.Parse(Console.ReadLine());
            Console.Write("Introduce el tercer número: ");
            tercerNum = int.Parse(Console.ReadLine());
            if (primerNum + segunNum == tercerNum || segunNum+tercerNum==primerNum || tercerNum+primerNum==segunNum)
                Console.WriteLine("IGUALES.");
            else
                Console.WriteLine("DISTINTOS.");
            Console.WriteLine("Pulsa una tecla para salir.");
            Console.ReadKey();

        }
    }
}
