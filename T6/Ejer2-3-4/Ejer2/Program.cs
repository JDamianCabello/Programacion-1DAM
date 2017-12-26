using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;
            Console.WriteLine("Introduce una frase y quitaré los espacios del inicio, final y ambos lados:");
            Console.Write("Frase: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            frase = Console.ReadLine();
            Console.ResetColor();
            Console.Write("\nTu texto sin espacios: ");
            Console.WriteLine("=======================================");
            Console.Write("\nQuitando a la derecha: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", TrimD(frase));
            Console.ResetColor();
            Console.Write("\nQuitando a la izquierda: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", TrimI(frase));
            Console.ResetColor();
            Console.Write("\nQuitando a ambos lados: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", TrimAll(frase));
            Console.ResetColor();
            Console.WriteLine("\nPulsa una tecla para salir....");
            Console.ReadKey();
        }

        static string TrimD(string s)
        {
            int aux = s.Length - 1;
            while(Char.IsSeparator(s[aux]))
                aux--;
            return s.Substring(0, aux + 1);
            
        }

        static string TrimI(string s)
        {
            int aux = 0;
            while (Char.IsSeparator(s[aux]))
                aux++;
            return s.Substring(aux, s.Length - aux);
        }

        static string TrimAll(string s)
        {
            string aux = string.Empty;
            aux = TrimD(s);
            aux = TrimI(aux);
            return aux;

        }
    }
}
