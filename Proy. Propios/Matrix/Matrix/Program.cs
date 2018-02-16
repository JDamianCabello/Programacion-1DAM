using System;

namespace Matrix
{
    class Program
    {
        static int anchoTablero = Console.WindowWidth - 1;
        static int altoTablero = Console.WindowHeight;
        static int MAXANCHOTABLERO = Console.WindowWidth - 1;
        static int MAXALTOTABLERO = Console.WindowHeight;
        static int velocidad = 30;
        static byte[,] tablero = TableroAlea(altoTablero, anchoTablero);
        static ConsoleColor colorFondo = ConsoleColor.DarkGray;
        static ConsoleColor colorDefectoLetra1 = ConsoleColor.DarkCyan;
        static ConsoleColor colorDefectoLetra2 = ConsoleColor.Gray;
        static bool resetAutomatico = false;
        static int contadorIteracionesReset = 5000;
        static int totalIteraciones = 0;


        static void Main(string[] args)
        {
            

            Console.CursorVisible = false;
            ConsoleKeyInfo tecla;
            GeneraTitulo();
            PintaTableroInicio(HazString(tablero));
            do
            {
                do
                {
                    Console.SetCursorPosition(0, 0);
                    if (resetAutomatico && totalIteraciones >= contadorIteracionesReset)
                    {
                        Console.Clear();
                        PintaTableroInicio(HazString(tablero));
                        totalIteraciones = 0;
                    }
                    Cascada(tablero, velocidad);
                } while (!Console.KeyAvailable);


                tecla = Console.ReadKey(true);

                if (tecla.Key == ConsoleKey.C)
                {
                    Console.Clear();
                    PintaTableroInicio(HazString(tablero));
                }

                if (tecla.Key == ConsoleKey.R)
                {
                    tablero = TableroAlea(altoTablero, anchoTablero);
                    Console.Clear();
                    PintaTableroInicio(HazString(tablero));
                }

                if (tecla.Key == ConsoleKey.Tab)
                {
                    Opciones();
                    tablero = TableroAlea(altoTablero, anchoTablero);
                    Console.Clear();
                    PintaTableroInicio(HazString(tablero));
                }

            } while (tecla.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Genera el título del programa
        /// </summary>
        /// <returns></returns>
        private static void GeneraTitulo()
        {
            string tmp = string.Empty;
            if (resetAutomatico)
                tmp = "Reseteo automatico: Activado en " + contadorIteracionesReset + " iteraciones    Total iteraciones: [" + totalIteraciones + "]    Opciones [Tab]    Restablece de inicio [C]    Reinica todo [R]      Creado por Damián Cabello"; 
            else
                tmp = "Reseteo automatico: Desactivado    Total iteraciones: [" + totalIteraciones + "]    Opciones [Tab]    Restablece de inicio [C]    Reinica todo [R]      Creado por Damián Cabello";

            Console.Title = tmp;
        }

        /// <summary>
        /// Controla las opciones del juego.
        /// </summary>
        private static void Opciones()
        {
            Random rnd = new Random();
            totalIteraciones = 0;
            Console.Title = "Opciones";
            Console.ResetColor();
            const int SEPARACION = 60;
            ConsoleKeyInfo tecla;
            Console.CursorVisible = false;
            int opcionSeleccionada = 1;
            ConsoleColor colorSeleccion = ConsoleColor.Blue;
            string aux = string.Empty;
            double tiempoPorLetra = 0;
            do
            {
                tiempoPorLetra = velocidad * 0.001;
                aux = resetAutomatico ? "   Activado" : "   Desactivado";
                Console.Clear();
                Console.ResetColor();
                Console.CursorTop = 20;
                Console.WriteLine("\t\t\tSeleccione la opción con las flechas arriba y abajo.");
                Console.WriteLine("\t\t\tCambie los valores de las opciones con las flechas izquierda y derecha.");
                Console.WriteLine("\t\t\tPulse la tecla [Esc] Escape, para volver a Matrix.");
                Console.WriteLine("\n");
                Console.WriteLine("Nota  : El total de iteraciones se refiere al total de letras que ha cambiado de color");
                Console.WriteLine("Nota 2: El reset automático hace que el juego se restablezca automáticamente (en N iteraciones seleccionadas debajo).");
                Console.WriteLine("Nota 3: El color del efecto cascada nunca será el mismo que el color que haya seleccionado de fondo.\n");
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.WriteLine("Mis repositorios de Git: https://github.com/JDamianCabello".PadLeft(SEPARACION + 30));
                Console.ResetColor();
                Console.SetCursorPosition(0, 0);
                Console.CursorTop = 3;
                Console.WriteLine("                OPCIONES".PadLeft(SEPARACION));
                Console.WriteLine("====================================================".PadLeft(SEPARACION + 20));
                Console.WriteLine();
                if (opcionSeleccionada == 1)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Velocidad:".PadLeft(SEPARACION));
                Console.WriteLine("   {0}\tEsquivale a: "+tiempoPorLetra+" segundo/s por letra", velocidad);
                Console.ResetColor();
                if (opcionSeleccionada == 2)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Reset Automático:".PadLeft(SEPARACION));
                Console.WriteLine("{0}",aux);
                Console.ResetColor();
                if (!resetAutomatico)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                if(opcionSeleccionada == 3 && resetAutomatico)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Total iteraciones antes del reset:".PadLeft(SEPARACION));
                Console.WriteLine("   {0}", contadorIteracionesReset);
                Console.ResetColor();
                if (opcionSeleccionada == 4)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Largo del recuadro:".PadLeft(SEPARACION));
                Console.WriteLine("   {0}", anchoTablero);
                Console.ResetColor();
                if (opcionSeleccionada == 5)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Alto del recuadro:".PadLeft(SEPARACION));
                Console.WriteLine("   {0}", altoTablero);
                Console.ResetColor();
                Console.WriteLine("\n\n");
                if (opcionSeleccionada == 6)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Seleccionar color de fondo:".PadLeft(SEPARACION));
                Console.Write(" |");
                Console.BackgroundColor = colorFondo;
                Console.Write("   ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("|");
                Console.ResetColor();
                Console.WriteLine();
                if (opcionSeleccionada == 7)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Selecciona el color por defecto de letra 1:".PadLeft(SEPARACION));
                Console.Write(" |");
                Console.BackgroundColor = colorDefectoLetra1;
                Console.Write("   ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("|");
                Console.ResetColor();
                Console.WriteLine();
                if (opcionSeleccionada == 8)
                    Console.ForegroundColor = colorSeleccion;
                Console.Write("Selecciona el color por defecto de letra 2:".PadLeft(SEPARACION));
                Console.Write(" |");
                Console.BackgroundColor = colorDefectoLetra2;
                Console.Write("   ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("|");
                Console.ResetColor();
                tecla = Console.ReadKey();

                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    if (opcionSeleccionada != 8)
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
                            if (anchoTablero != 5)
                                anchoTablero -= 1;
                            break;
                        case 5:
                            if (altoTablero != 5)
                                altoTablero -= 1;
                            break;
                        case 6:
                            if (colorFondo != ConsoleColor.Black)
                                colorFondo = colorFondo - 1;
                            break;
                        case 7:
                            if (colorDefectoLetra1 != ConsoleColor.Black)
                                colorDefectoLetra1 -= 1;
                            break;
                        case 8:
                            if (colorDefectoLetra2 != ConsoleColor.Black)
                                colorDefectoLetra2 -= 1;
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
                            if (anchoTablero != MAXANCHOTABLERO)
                                anchoTablero += 1;
                            break;
                        case 5:
                            if (altoTablero != MAXALTOTABLERO)
                                altoTablero += 1;
                            break;
                        case 6:
                            if (colorFondo != ConsoleColor.White)
                                colorFondo = colorFondo + 1;
                            break;
                        case 7:
                            if (colorDefectoLetra1 != ConsoleColor.White)
                                colorDefectoLetra1 = colorDefectoLetra1 + 1;
                            break;
                        case 8:
                            if (colorDefectoLetra2 != ConsoleColor.White)
                                colorDefectoLetra2 = colorDefectoLetra2 + 1;
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
                        Console.ForegroundColor = colorDefectoLetra1;
                        break;
                    case 1:
                        Console.ForegroundColor = colorDefectoLetra2;
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

                do
                {
                    Console.ForegroundColor = (ConsoleColor)(rnd.Next(0, 16)); 
                } while (Console.ForegroundColor == colorFondo);
                Console.Write(a[ejeY,ejeX]);
                System.Threading.Thread.Sleep(velocidad);
                totalIteraciones++;
                GeneraTitulo();
            }

        }
    }
}
