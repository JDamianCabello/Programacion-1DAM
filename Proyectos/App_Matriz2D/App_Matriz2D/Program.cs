using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Matriz2D
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NFILAS = 10;
            const int NCOL = 10;
            int[,] m2 = CrearM2Alea(NFILAS,NCOL,100);

            //MostrarMatriz(CrearM2(NFILAS,NCOL,0));
            //Console.WriteLine("\n\n");
            MostrarMatriz(m2);
        }

        /// <summary>
        /// Crea una matriz y la devuelve llenas de el parámetro que se le pase por valores.
        /// </summary>
        /// <param name="nFilas"></param>
        /// <param name="nCol"></param>
        /// <returns></returns>
        static int[,] CrearM2(int nFilas, int nCol, int valor)
        {
            int[,] aux = new int[nFilas, nCol];

            for(int i = 0; i < nFilas; i++)
                for(int j = 0; j < nCol; j++)
                    aux[i, j] = valor;

            return aux;
        }

        static int[,] CrearM2Alea(int nFilas, int nCol, int maxAlea)
        {
            Random rnd = new Random();
            int[,] aux = new int[nFilas, nCol];

            for(int i = 0; i < nFilas; i++)
                for(int j = 0; j < nCol; j++)
                    aux[i, j] = rnd.Next(maxAlea);

            return aux;
        }

        /// <summary>
        /// Muestra en consola el contenido de la matriz de 2D.
        /// </summary>
        /// <param name="m"></param>
        static void MostrarMatriz(int[,] m)
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                    Console.Write("{0,3}",m[i, j]);
                Console.WriteLine();
            }
        }
    }
}
