using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = ' ';
            Console.WriteLine("Programa que convierte a mayúsculas");
            Console.Write("Introduce un caracter: ");
            while(letra != '*')
            {
                letra = (char)Console.Read();
                Console.ReadLine();
                if(char.IsLetter(letra))
                {
                    Console.WriteLine("Tu letra es {0} y en mayúscula es {1}", letra, (char)((int)letra-32));
                    Console.Write("\nIntroduce otra letra: ");
                }
                else
                    if(letra != '*')
                    {
                        Console.WriteLine("Lo que has introducido no es una letra.");
                        Console.Write("\nIntroduce otra letra: ");
                    }

            }
        }
    }
}
