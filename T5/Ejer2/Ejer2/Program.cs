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
            Console.CursorVisible = false;
            int[] array = CreaAleatorio(100);
            MuestraArray(array);

            Console.WriteLine("\n\nRECUENTO");
            Console.WriteLine("============");
            Console.WriteLine("Hay {0} numeros positivos.", CuentaPositivos(array));
            Console.WriteLine("Hay {0} numeros negativos.", CuentaNegativos(array));
            Console.WriteLine("Hay {0} ceros.", CuentaCeros(array));
            Console.Write("\n\nPulsa una tecla para salir....");
            Console.ReadKey();
        }

        static int[] CreaAleatorio(int longitud)
        {
            Random rnd = new Random();
            int[] aux = new int[longitud];

            for (int i = 0; i < aux.Length; i++)
                aux[i] = rnd.Next(-99, 100);

            return aux;
        }

        static void MuestraArray(int[] a)
        {
            Console.WriteLine("Mostrando un array de {0} enteros de longitud, aleatorios.",a.Length);
            Console.WriteLine("==========================================================");
            for (int i = 0; i < a.Length; i++)
            {
                if(i%10==0)
                    Console.WriteLine();
                Console.Write("{0,4}", a[i]);
                
            }
            Console.WriteLine("\n\n");
        }

        static int CuentaPositivos(int[] a)
        {
            int aux = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] > 0)
                    aux++;

            return aux;
        }

        static int CuentaNegativos(int[] a)
        {
            int aux = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] < 0)
                    aux++;

            return aux;
        }

        static int CuentaCeros(int[] a)
        {
            int aux = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == 0)
                    aux++;

            return aux;
        }
    }
}
