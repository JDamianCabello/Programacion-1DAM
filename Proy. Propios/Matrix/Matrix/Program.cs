using System;

namespace Matrix
{
    class Program
    {
        static int velocidad = 30;
        static byte[,] tablero = TableroAlea(Console.WindowHeight, Console.WindowWidth-1);
        static ConsoleColor colorFondo = ConsoleColor.DarkGray;
        static bool resetAutomatico = false;
        static int contadorIteracionesReset = 5000;
        static int totalIteraciones = 0;

        static void Main(string[] args)
        {
            

            Console.CursorVisible = false;
            ConsoleKeyInfo tecla;
            Console.Title = GeneraTitulo();

            PintaTableroInicio(HazString(tablero));
            do
            {
                do
                {
                    if (resetAutomatico && totalIteraciones >= contadorIteracionesReset)
                    {
                        Console.Clear();
                        PintaTableroInicio(HazString(tablero));
                        totalIteraciones = 0;
                    }
                    Cascada(tablero, velocidad);
                } while (!Console.KeyAvailable);


                tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.Tab)
                {
                    Opciones();
                    Console.Clear();
                    PintaTableroInicio(HazString(tablero));
                }

            } while (tecla.Key != ConsoleKey.Escape);
        }

        private static string GeneraTitulo()
        {
            if (resetAutomatico)
                return "Reseteo automatico: Activado en " + contadorIteracionesReset + " iteraciones    Total Iteraciones: [" + totalIteraciones + "]    Opciones [Tab]      Creado por Damián Cabello"; 
            else
                return "Reseteo automatico: Desactivado    Total Iteraciones: [" + totalIteraciones + "]    Opciones [Tab]    Creado por Damián Cabello";
        }

        private static void Opciones()
        {
            Random rnd = new Random();
            totalIteraciones = 0;
            Console.Title = "Opciones";
            Console.ResetColor();
            int separacion = 60;
            ConsoleKeyInfo tecla;
            Console.CursorVisible = false;
            int opcionSeleccionada = 1;
            ConsoleColor colorSeleccion = ConsoleColor.Cyan;
            string aux = string.Empty;

            do
            {
                aux = resetAutomatico ? "   Activado" : "   Desactivado";
                Console.Clear();
                Console.ResetColor();
                Console.CursorTop = 20;
                Console.WriteLine("\t\t\tSeleccione la opción con las flechas arriba y abajo.");
                Console.WriteLine("\t\t\tCambie los valores de las opciones con las flechas izquierda y derecha.");
                Console.WriteLine("\t\t\tPulse la tecla [Esc] Escape, para volver a Matrix.");
                Console.WriteLine("\n");
                Console.WriteLine("Nota  : El total de iteraciones se refiere al total de letras que ha cambiado de color");
                Console.WriteLine("Nota 2: El reset automático hace que el juego se restablezca automáticamente (en N iteraciones seleccionadas debajo).\n");
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.WriteLine("Mis repositorios de Git: https://github.com/JDamianCabello".PadLeft(separacion + 30));
                Console.ResetColor();
                Console.SetCursorPosition(0, 0);
                Console.CursorTop = 3;
                Console.WriteLine("                OPCIONES".PadLeft(separacion));
                Console.WriteLine("====================================================".PadLeft(separacion + 20));
                Console.WriteLine();
                if (opcionSeleccionada == 1)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Velocidad:".PadLeft(separacion));
                Console.WriteLine("   {0}", velocidad);
                Console.ResetColor();
                if (opcionSeleccionada == 2)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Reset Automático:".PadLeft(separacion));
                Console.WriteLine("{0}",aux);
                Console.ResetColor();
                if (!resetAutomatico)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                if(opcionSeleccionada == 3 && resetAutomatico)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Total iteraciones antes del reset:".PadLeft(separacion));
                Console.WriteLine("   {0}", contadorIteracionesReset);
                Console.ResetColor();
                Console.WriteLine("\n\n");
                if (opcionSeleccionada == 4)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Seleccionar color de fondo:".PadLeft(separacion));
                Console.Write(" |");
                Console.BackgroundColor = colorFondo;
                Console.Write("   ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("|");
                Console.ResetColor();
                tecla = Console.ReadKey();

                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (opcionSeleccionada != 4)
                        if(opcionSeleccionada == 2 && !resetAutomatico)
                            opcionSeleccionada += 2;
                        else
                            opcionSeleccionada += 1;
                }

                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if (opcionSeleccionada != 1)
                        if (opcionSeleccionada == 4 && !resetAutomatico)
                            opcionSeleccionada -= 2;
                        else
                            opcionSeleccionada -= 1;
                }

                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    switch (opcionSeleccionada)
                    {
                        case 1:
                            if (velocidad != 0)
                                velocidad -= 10;
                            break;
                        case 2:
                            if (resetAutomatico)
                                resetAutomatico = false;
                            else
                                resetAutomatico = true;
                            break;
                        case 3:
                            if (contadorIteracionesReset != 1000)
                                contadorIteracionesReset -= 500;
                            break;
                        case 4:
                            if (colorFondo != ConsoleColor.Black)
                                colorFondo = (ConsoleColor)colorFondo - 1;
                            break;
                    }
                }

                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    switch (opcionSeleccionada)
                    {
                        case 1:
                            if (velocidad != 2000)
                                velocidad += 10;
                            break;
                        case 2:
                            if (resetAutomatico)
                                resetAutomatico = false;
                            else
                                resetAutomatico = true;
                            break;
                        case 3:
                            if (contadorIteracionesReset != 50000)
                                contadorIteracionesReset += 500;
                            break;
                        case 4:
                            if (colorFondo != ConsoleColor.White)
                                colorFondo = (ConsoleColor)colorFondo + 1;
                            break;
                    }
                }
            } while (tecla.Key != ConsoleKey.Escape);
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
            Console.BackgroundColor = colorFondo;
            Console.Clear();
            for(int i = 0; i < tablero.Length; i++)
            {
                switch(rnd.Next(0, 2))
                {

                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Gray;
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
            for(int i = 0; i <= posDesplazamiento; i++)
            {
                Console.SetCursorPosition(ejeX, ejeY + i);
                
                Console.ForegroundColor = (ConsoleColor)(rnd.Next(0, 16));
                Console.Write(a[ejeY,ejeX]);
                System.Threading.Thread.Sleep(velocidad);
                totalIteraciones++;
                Console.Title = GeneraTitulo();
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
