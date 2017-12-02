using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    class Program
    {
        static int[] datos = new int[20];
        static int[] copiaDatos = new int[datos.Length];

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            HazAlgo();
        }

        static void ArrayAlea(int total)
        {
            total += 1;
            Random rnd = new Random();
            for(int i = 0; i < datos.Length; i++)
                datos[i] = rnd.Next(0,total);

            CopiaArray();
        }

        static void CopiaArray()
        {
            for(int i = 0; i < datos.Length; i++)
                copiaDatos[i] = datos[i];
        }

        static void EscribeDesordenado()
        {
            Console.WriteLine("Array desordenado:");
            Console.WriteLine("============================================================");
            for(int i = 0; i < copiaDatos.Length; i++)
                Console.Write("{0,3}",copiaDatos[i]);
        }

        static void EscribeOrdenado()
        {
            Console.WriteLine("Array ordenado:");
            Console.WriteLine("============================================================");
            for(int i = 0; i < datos.Length; i++)
                Console.Write("{0,3}", datos[i]);
        }

        static void Burbuja()
        {
            int aux = 0;
            for(int i = 1; i < datos.Length; i++)
                for(int j = datos.Length - 1; j >= i; j--)
                    if(datos[j] < datos[j - 1])
                    {
                        aux = datos[j];
                        datos[j] = datos[j - 1];
                        datos[j - 1] = aux;
                    }
        }

        static void HazAlgo()
        {
            ArrayAlea(99);
            CopiaArray();
            Burbuja();
            EscribeDesordenado();
            Console.WriteLine("\n");
            EscribeOrdenado();
            Console.ReadKey();

        }
    }
}
