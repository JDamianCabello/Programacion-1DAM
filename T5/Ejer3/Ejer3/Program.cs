using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int[] array = CreaAleatorio(100);
            MuestraArray(array);

            Console.WriteLine("\n\nINFORMAIÓN");
            Console.WriteLine("====================");
            Console.WriteLine("La media del array es: {0}.", Media(array));
            Console.WriteLine("El mayor del array es: {0}.", Maximo(array));
            Console.WriteLine("El menor del array es: {0}.", Menor (array));
            Console.Write("\n\nPulsa una tecla para salir....");
            Console.ReadKey();
        }

        static int[] CreaAleatorio(int longitud)
        {
            Random rnd = new Random();
            int[] aux = new int[longitud];

            for (int i = 0; i < aux.Length; i++)
                aux[i] = rnd.Next(0, 100);

            return aux;
        }

        static void MuestraArray(int[] a)
        {
            Console.WriteLine("Mostrando un array de {0} enteros de longitud, aleatorios.", a.Length);
            Console.WriteLine("==========================================================");
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write("{0,3}", a[i]);

            }
            Console.WriteLine("\n\n");
        }

        static int Media(int[] a)
        {
            int aux = 0;
            for (int i = 0; i < a.Length; i++)
                aux += a[i];

            return aux / a.Length;
        }

        static int Maximo(int[] a)
        {
            int aux = 0;

            for (int i = 0; i < a.Length; i++)
                if (a[i] > aux)
                    aux = a[i];

            return aux;
        }

        static int Menor(int[] a)
        {
            int aux = 100;

            for (int i = 0; i < a.Length; i++)
                if (a[i] < aux)
                    aux = a[i];

            return aux;
        }
    }
}
