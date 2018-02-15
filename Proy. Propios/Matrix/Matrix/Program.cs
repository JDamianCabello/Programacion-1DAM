using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] tablero = TableroAlea(Console.WindowHeight -1,Console.WindowWidth-1);

            Console.CursorVisible = false;
            PintaTableroInicio(HazString(tablero));
            ConsoleKeyInfo tecla;
            int velocidad = 30;
            do
            {
                tecla = Console.ReadKey(true);
                switch(tecla.Key)
                {
                    case ConsoleKey.A: //Automático
                        do
                        {
                            Cascada(tablero,velocidad);
                        } while(!Console.KeyAvailable);
                        break;
                    case ConsoleKey.C: //Limpia tablero
                        Console.Clear();
                        PintaTableroInicio(HazString(tablero));
                        break;
                    case ConsoleKey.Subtract: //Disminuye velocidad
                        velocidad = velocidad == 0 ? 0 : velocidad -= 10;
                        break;
                    case ConsoleKey.Add: //Aumenta velocidad
                        velocidad = velocidad == 3000 ? 3000 : velocidad += 10;
                        break;
                }

            } while(tecla.Key != ConsoleKey.Escape);

        }

        private static byte[,] TableroAlea(int alto, int largo)
        {
            Random rnd = new Random();
            byte[,] aux = new byte[alto, largo];
            for(int i = 0; i < alto; i++)
            {
                for(int j = 0; j < largo; j++)
                {
                    aux[i, j] = (byte)rnd.Next(0, 2);
                }
            }

            return aux;
        }

        private static string HazString(byte[,]a)
        {
            string tmp = string.Empty;
            for (int i = 0; i < a.GetLength(0); i++)
			{
                for (int j = 0; j < a.GetLength(1); j++)
			    {
                   tmp += a[i,j];
			    }
                tmp += "\n";
			}

            return tmp;
        }

        private static void PintaTableroInicio(string tablero)
        {
            Random rnd = new Random();
            for(int i = 0; i < tablero.Length; i++)
            {
                switch(rnd.Next(0, 2))
                {

                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.Write(tablero[i]);
            }
        }

        private static void Cascada(byte[,] a, int velocidad)
        {
            Random rnd = new Random();
            int ejeY = rnd.Next(0,a.GetLength(0));
            System.Threading.Thread.Sleep(5);
            int ejeX = rnd.Next(0,a.GetLength(1));
            int posCambio = a.GetLength(0) - ejeY - 1;
            int posDesplazamiento = rnd.Next(0, posCambio + 1);
            for(int i = 0; i < posDesplazamiento; i++)
            {
                Console.SetCursorPosition(ejeX, ejeY + i);
                
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(0, 16));
                Console.Write(a[ejeY,ejeX]);
                System.Threading.Thread.Sleep(velocidad);
            }

        }

        private static void PintaInicio(byte[,] a)
        {
            Random rnd = new Random();

            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    switch(rnd.Next(0,2))
                    {
                        
                        case 0:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                    }

                    Console.Write(a[i, j]);
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(1);
                }
                Console.WriteLine();
            }
        }



    }
}
