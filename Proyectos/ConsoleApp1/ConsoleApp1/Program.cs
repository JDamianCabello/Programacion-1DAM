using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] desordenado = AleaSinRepeticion(5, 10);
            Console.WriteLine(Pinta(desordenado));

            Console.WriteLine("\n\n\n");
            Console.WriteLine(Pinta(OrdenaCutre(desordenado)));

            Console.ReadKey();
        }

        static int[,] AleaSinRepeticion (int filas, int columnas)
        {
            int[,] aux = new int[filas, columnas];
            Random rnd = new Random();
            int tmp = 0;
            for (int i = 0; i < aux.GetLength(0); i++)
                for (int j = 0; j < aux.GetLength(1); j++)
                    do
                    {
                        tmp = rnd.Next(100, 150);
                        if (CompruebaRepeticion(aux, tmp))
                            continue;
                        else
                        {
                            aux[i,j] = tmp;
                            break;
                        }
                    } while (true);

            return aux;
        }

        static bool CompruebaRepeticion(int[,] array, int numero)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i,j] == numero)
                        return true;

            return false;
        }

        static string Pinta(int[,] a)
        {
            string aux = string.Empty;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    aux += a[i, j] + "\t";
                aux +="\n";
            }

            return aux;
        }


        static void OrdBurbuja(int[] vector, int nDatos)
        {
            int aux = 0;

            for (int i = 1; i < nDatos; i++)
                for (int j = nDatos - 1; j >= i; j--)
                    if (vector[j] < vector[j - 1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = aux;
                    }
        }


        static bool Insertar(int[] vector, int dato, int pos, ref int nDatos)
        {
            //inserta el dato en la posición pos.
            if (nDatos == vector.Length || pos < 0 || pos > nDatos)
                return false;

            for (int i = nDatos; i > pos; i--)
                vector[i] = vector[i - 1];

            vector[pos] = dato;
            nDatos++;

            return true;
        }

        static int[,] OrdenaCutre(int[,] a)
        {
            int[] aux1D = new int[a.GetLength(0) * a.GetLength(1)];
            int contador = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    aux1D[contador++] = a[i, j];

            Array.Sort(aux1D);

            int[,] aux2D = new int[a.GetLength(0), a.GetLength(1)];
            contador = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    aux2D[i, j] = aux1D[contador++];

            return aux2D;
        }

        /// <summary>
        /// Busca de forma binaria el dato buscado en el array vector.
        /// IMPORTANTE: El array tiene que estar ordenado
        /// </summary>
        /// <param name="vector">Array donde se hace las búsqueda.</param>
        /// <param name="buscado">Valor a buscar</param>
        /// <returns>-1 si no está, otro valos positivo con la posicion del dato si lo 			encuentra</returns>
        static int BusquedaBinaria(int[] vector, int buscado)
        {
            int tamano = vector.Length;
            int inicio = 0;
            int final = tamano - 1;
            int medio = (inicio + final) / 2;

            while (vector[medio] != buscado && inicio <= final)
            {
                medio = (inicio + final) / 2;
                if (buscado > vector[medio])
                    inicio = medio + 1;
                else
                    final = medio - 1;
            }

            if (vector[medio] == buscado)
                return medio;
            return -1;
        }

        static int BusquedaSecuencial(int[] vector, int buscado)
        {
            int tamano = vector.Length;
            int contador = 0;
            if (tamano == 0)
                return -1;

            while (contador < tamano && buscado != vector[contador])
                contador++;

            if (contador >= tamano)
                return -1;
            else
                return contador;
        }

        static int BorrarElemento(int[] vector, int pos, ref int nDatos)
        {
            if (nDatos == 0 || pos < 0 || pos > nDatos - 1)
                return -1;
            for (int i = pos; i < nDatos - 1; i++)
                vector[i] = vector[i + 1];

            nDatos--;

            return pos;
        }
    }
}
