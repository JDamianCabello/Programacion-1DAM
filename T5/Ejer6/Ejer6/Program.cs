using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            const int TOTAL = 20;
            int[,] matriz = new int[TOTAL, TOTAL];
            int[,] copiaMatriz = new int[matriz.GetLength(0), matriz.GetLength(1)];
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                UIMenu();
                tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Console.WriteLine("Inicializando la matriz original a 0....");
                        inicializaCero(matriz);
                        Console.WriteLine("Matriz correctamente inicializada a 0. Pulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine("Inicializando la matriz original aleatoriamente....");
                        MatrizAlea(matriz);
                        Console.WriteLine("Matriz correctamente inicializada aleatoriamente. Pulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine("Copiando la matriz original....");
                        CopiarMatriz(matriz, copiaMatriz);
                        Console.WriteLine("Matriz correctamente copiada. Pulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        Console.WriteLine("Mostrando la matriz original....");
                        Mostrar(matriz);
                        Console.WriteLine("Matriz correctamente mostrada. Pulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        Console.WriteLine("Mostrando la matriz copiada....");
                        Mostrar(copiaMatriz);
                        Console.WriteLine("Matriz correctamente mostrada. Pulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                }
            } while (tecla.Key != ConsoleKey.Escape);

            
            MatrizAlea(matriz);
            Mostrar(matriz);
        }

        static void MatrizAlea(int[,] m)
        {
            Random rnd = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i, j] = rnd.Next(0, 100);

        }

        static void Mostrar(int[,] m)
        {
            Console.WriteLine("\n\n");
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write("{0,3}", m[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }

        static void CopiarMatriz(int[,] original, int[,] copia)
        {
            for (int i = 0; i < original.GetLength(0); i++)
                for (int j = 0; j < original.GetLength(1); j++)
                    copia[i, j] = original[i, j];
        }

        static void inicializaCero(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i, j] = 0;
        }

        static void UIMenu()
        {
            Console.WriteLine("Menú principal");
            Console.WriteLine("===============================");
            Console.WriteLine("1. Inicializar matriz  0.");
            Console.WriteLine("2. Inicializar matriz aleatoriamente.");
            Console.WriteLine("3. Copiar matriz en otra.");
            Console.WriteLine("4. Mostrar matriz original.");
            Console.WriteLine("5. Mostrar matriz copiada.");
            Console.WriteLine("\nEsc Salir.");
            Console.WriteLine("\n\nSelecciona una opción.");
        }
    }
}
