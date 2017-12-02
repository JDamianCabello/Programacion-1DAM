using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LONGITUD = 20;
            int[] vector1 = new int[LONGITUD];
            int[] vector2 = { 1, 3, 10, 5, 7, 2 };
            int[] vectorOrd = { 1, 20, 30, 40, 50, 60, 71, 84, 99 };
            int buscar = 71;
            int pos = BusquedaBinaria(vectorOrd,buscar);

            if(pos != -1)
                Console.WriteLine("En valor {0} encontrado en {1}",buscar,pos);
            else
                Console.WriteLine("En valor {0} no encontrado", buscar);

            Console.ReadKey();
            /*
            InicializaZero(vector1);
            Mostrar(vector1);

            InicializaZero(vector1,9);
            Mostrar(vector1);

            InicializaAlea(vector1, 100);
            Mostrar(vector1);

            MostrarAlReves(vector1);

            MostrarCircular(vector1);
            */
        }

        /// <summary>
        /// Busca de forma binaria el dato buscado en el array vector.
        /// IMPORTANTE: El array tiene que estar ordenado
        /// </summary>
        /// <param name="vector">Array donde se hace las búsqueda.</param>
        /// <param name="buscado">Valor a buscar</param>
        /// <returns>-1 si no está, otro valos positivo con la posicion del dato si lo encuentra</returns>
        static int BusquedaBinaria(int[] vector, int buscado)
        {
            int tamano = vector.Length;
            int inicio = 0;
            int final = tamano - 1;
            int medio = (inicio + final) / 2;

            while(vector[medio] != buscado && inicio <= final)
            {
                medio = (inicio + final) / 2;
                if(buscado > vector[medio])
                    inicio = medio + 1;
                else
                    final = medio - 1;
            }

            if(vector[medio] == buscado)
                return medio;
            return -1; 
        }

        /// <summary>
        /// Busca de forma secuencial el dato buscado en el array vector.
        /// </summary>
        /// <param name="vector">Array donde se hace las búsqueda.</param>
        /// <param name="buscado">Valor a buscar</param>
        /// <returns>-1 si no está, otro valos positivo con la posicion del dato si lo encuentra</returns>
        static int BusquedaSecuencial(int[] vector, int buscado)
        {
            int tamano = vector.Length; 
            int contador = 0;
            if(tamano == 0)
                return -1;

            while(contador < tamano && buscado != vector[contador])
                contador++;

            if(contador >= tamano)
                return -1;
            else
                return contador;
        }

        static void InicializaZero(int[] a)
        {
            //Inicializa el array 'a' a 0

            for(int i = 0; i < a.Length; i++)
                a[i] = 0;
        }
        
        static void InicializaZero(int[] a, int valor)
        { 
            //Inicializa el array 'a' a valor

            for(int i = 0; i < a.Length; i++)
                a[i] = valor;
        }

        static void InicializaAlea(int[] a, int limite)
        {
            //Inicializa el array 'a' aleatoriamente hasta límite - 1.
            Random rnd = new Random();
            for(int i = 0; i < a.Length; i++)
                a[i] = rnd.Next(limite);
        }

        static void Mostrar(int[] a)
        {

            for(int i = 0; i < a.Length; i++)
                Console.Write("{0,3}, ",a[i]);

            Console.WriteLine("\n\nNo hay mas datos a mostrar.....");
            Console.ReadKey();
        }

        static void MostrarAlReves(int[] a)
        {

            for(int i = a.Length - 1; i >= 0; i--)
                Console.Write("{0,3}, ", a[i]);

            Console.WriteLine("\n\nNo hay mas datos a mostrar.....");
            Console.ReadKey();
        }

        static void MostrarCircular(int[] a)
        {

            for(int i = 0; i < a.Length * 3; i++)
                Console.Write("{0,3}, ", a[i % a.Length]);

            Console.WriteLine("\n\nNo hay mas datos a mostrar.....");
            Console.ReadKey();
        }
    }
}
