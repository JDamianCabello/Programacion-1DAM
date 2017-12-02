using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] total = new int[5]; 
            string frase = string.Empty;
            Console.WriteLine("Programa que lee por teclado N caracteres y contabilice el número total de cada vocal.");
            Console.WriteLine("También admite frases");
            Console.WriteLine("Introduce * para ver el recuento y salir.");
            do
            {
                Console.Write("\n Introduce una letra/frase: ");
                frase = Console.ReadLine();
                for (int i = 0; i < frase.Length; i++)
                {
                    switch (frase[i])
                    {
                        case 'a':
                            total[0]++;
                            break;
                        case 'e':
                            total[1]++;
                            break;
                        case 'i':
                            total[2]++;
                            break;
                        case 'o':
                            total[3]++;
                            break;
                        case 'u':
                            total[4]++;
                            break;
                        default:
                            break;
                    }
                }
            } while (frase != "*");

            Console.Clear();
            Console.WriteLine("             RECUENTO");
            Console.WriteLine("======================================");
            Console.WriteLine("\t\tA: {0}", total[0]);
            Console.WriteLine("\t\tE: {0}", total[1]);
            Console.WriteLine("\t\tI: {0}", total[2]);
            Console.WriteLine("\t\tO: {0}", total[3]);
            Console.WriteLine("\t\tU: {0}", total[4]);
            Console.WriteLine("\nEn total han sido {0} vocales.",total[0]+total[1]+total[2]+total[3]+total[4]);
            Console.WriteLine("\n\nFin recuento... Pulsa una tecla para salir.");
            Console.ReadKey();

        }
    }
}
