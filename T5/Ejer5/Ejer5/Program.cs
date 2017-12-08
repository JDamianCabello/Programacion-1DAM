using System;

namespace Ejer5
{
    class Program
    {
        static int[] datos = new int[20];

        static void Main(string[] args)
        {
            int aux = 0;
            int PosBusqueda = 0;
            ArrayAlea(99);
            EscribeDesordenado();
            Console.WriteLine("\n\n");
            Burbuja();
            EscribeOrdenado();
            Console.WriteLine("\n\n");

            Console.Write("Introduce el valor del dato a buscar: ");
            aux = int.Parse(Console.ReadLine());
            PosBusqueda = BusquedaBinaria(aux);
            if(PosBusqueda == -1)
                Console.WriteLine("El valor buscado NO está en la colección.");
            else
                Console.WriteLine("El valor buscado está en la posición {0}\n",PosBusqueda + 1);
            Busqueda(PosBusqueda);

            Console.CursorTop = 12;
            Console.WriteLine("\n\nPulsa una tecla para salir.....");
            Console.ReadKey();
        }

        /// <summary>
        /// Busca de forma binaria el dato buscado en el array vector.
        /// IMPORTANTE: El array tiene que estar ordenado
        /// </summary>
        /// <param name="vector">Array donde se hace las búsqueda.</param>
        /// <param name="buscado">Valor a buscar</param>
        /// <returns>-1 si no está, otro valos positivo con la posicion del dato si lo 			encuentra</returns>
        static int BusquedaBinaria(int buscado)
        {
            int tamano = datos.Length;
            int inicio = 0;
            int final = tamano - 1;
            int medio = (inicio + final) / 2;

            while (datos[medio] != buscado && inicio <= final)
            {
                medio = (inicio + final) / 2;
                if (buscado > datos[medio])
                    inicio = medio + 1;
                else
                    final = medio - 1;
            }

            if (datos[medio] == buscado)
                return medio;
            return -1;
        }

        static void ArrayAlea(int total)
        {
            total += 1;
            Random rnd = new Random();
            for (int i = 0; i < datos.Length; i++)
                datos[i] = rnd.Next(0, total);
        }

        static void Busqueda(int posBuscada)
        {
            Console.CursorTop = 9;
            for (int i = 0; i < datos.Length; i++)
            {
                if (posBuscada == i)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0,3}", datos[i]);
                Console.ResetColor();
            }
        }

        static void EscribeDesordenado()
        {
            Console.WriteLine("Array desordenado:");
            Console.WriteLine("============================================================");
            for (int i = 0; i < datos.Length; i++)
                Console.Write("{0,3}", datos[i]);
        }

        static void EscribeOrdenado()
        {
            Console.WriteLine("Array ordenado:");
            Console.WriteLine("============================================================");
            for (int i = 0; i < datos.Length; i++)
                Console.Write("{0,3}", datos[i]);
        }

        static void Burbuja()
        {
            Console.WriteLine("Ordenando para que se pueda buscar en él.....\n");
            int aux = 0;
            for (int i = 1; i < datos.Length; i++)
                for (int j = datos.Length - 1; j >= i; j--)
                    if (datos[j] < datos[j - 1])
                    {
                        aux = datos[j];
                        datos[j] = datos[j - 1];
                        datos[j - 1] = aux;
                    }
        }

    }
}
