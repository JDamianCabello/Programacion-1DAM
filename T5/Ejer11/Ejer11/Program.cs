using System;

namespace Ejer11
{
    class Program
    {
        static void Main(string[] args)
        {
            uint tiradas = 0;
            Console.CursorVisible = true;
            int[] array;
            bool flag = false;
            Console.WriteLine("Programa que simula tiradas de un dado.");
            do
            {
                
                Console.Write("\nIntroduce el número de tiradas: ");
                try
                {
                    tiradas = uint.Parse(Console.ReadLine());
                    Console.CursorVisible = false;
                    flag = true;
                    array = CreaAleatorio((int)tiradas);
                    MuestraArray(array);

                    MuestraEstadisticas(array);
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Formato incorrecto.");
                    Console.ResetColor();
                }

                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El número es negativo o demasiado grande.");
                    Console.ResetColor();
                }

                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se introdujo ningún valor.");
                    Console.ResetColor();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Ni idea de qué ha pasado....");
                    Console.WriteLine(e.Message);
                } 
            } while (!flag);

                Console.Write("\n\nPulsa una tecla para salir....");
                Console.ReadKey();
        }

        static int[] CreaAleatorio(int longitud)
        {
            Random rnd = new Random();
            int[] aux = new int[longitud];

            for (int i = 0; i < aux.Length; i++)
                aux[i] = rnd.Next(1, 7);

            return aux;
        }

        static void MuestraArray(int[] a)
        {
            Console.WriteLine("Mostrando un array de {0} tiradas.", a.Length);
            Console.WriteLine("==========================================================");
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write("{0,2}", a[i]);

            }
            Console.WriteLine("\n\n");
        }

        static void MuestraEstadisticas(int[] a)
        {
            int[] total = new int[6];
            Console.WriteLine("Mostrando estadísticas.", a.Length);
            Console.WriteLine("=======================");
            for (int i = 0; i < a.Length; i++)
                switch (a[i])
                {
                    case 1: total[0]++; break;
                    case 2: total[1]++; break;
                    case 3: total[2]++; break;
                    case 4: total[3]++; break;
                    case 5: total[4]++; break;
                    case 6: total[5]++; break;
                }
            Console.WriteLine("El número 1 aparece {0} veces. [{1}% del total]" ,total[0], total[0] * 100 / a.Length);
            Console.WriteLine("El número 2 aparece {0} veces. [{1}% del total]", total[1], total[1] * 100 / a.Length);
            Console.WriteLine("El número 3 aparece {0} veces. [{1}% del total]", total[2], total[2] * 100 / a.Length);
            Console.WriteLine("El número 4 aparece {0} veces. [{1}% del total]", total[3], total[3] * 100 / a.Length);
            Console.WriteLine("El número 5 aparece {0} veces. [{1}% del total]", total[4], total[4] * 100 / a.Length);
            Console.WriteLine("El número 6 aparece {0} veces. [{1}% del total]", total[5], total[5] * 100 / a.Length);
        }
    }
}
