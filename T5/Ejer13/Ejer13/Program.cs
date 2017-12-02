using System;
using System.Threading;

namespace Ejer13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            JuegoVida unJuego = new JuegoVida(20, 80,15,0);
            //JuegoVida unJuego = new JuegoVida();
            Console.WindowWidth = Console.LargestWindowWidth - Console.LargestWindowWidth/4;
            Console.WindowHeight = Console.LargestWindowHeight - Console.LargestWindowHeight/4;
            unJuego.CreaTablero();
            //unJuego.CreaAleatorio();
            //unJuego.MostrarTablero();
            Console.ReadLine();
            do
            {
                Console.Title = unJuego.Contador.ToString();
                unJuego.SiguienteIteracion();
                Thread.Sleep(100);
            } while(!Console.KeyAvailable);
        }

    }

    public class JuegoVida
    {
        static private sbyte[,] spin_hor = { { 1, 1, 1 } };
        static private sbyte[,] spin_ver = { { 1 }, { 1 }, { 1 } };
        static private sbyte[,] barco = { { 1, 1, 0 }, { 1, 0, 1 }, { 0, 1, 0 } };
        static private sbyte[,] sapo = { { 0, 1, 1, 1 }, { 1, 1, 1, 0 } };
        static private sbyte[,] planeador = { { 1, 1, 1 }, { 1, 0, 0 }, { 0, 1, 0 } };
        static private sbyte[,] nave = { { 0, 1, 0, 0, 1 }, { 1, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1 }, { 1, 1, 1, 1, 0 } };
        static private sbyte[,] diehard = { { 0, 0, 0, 0, 0, 0, 1, 0 }, { 1, 1, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 1, 1, 1 } };
        static private sbyte[,] acorn = { { 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 0 }, { 1, 1, 0, 0, 1, 1, 1 } };


        static private sbyte[,] _Tablero;
        static private sbyte _TotalEjeX;
        static private sbyte _TotalEjeY;
        uint _Contador;
        const sbyte MARGENBORDE = 1;
        static private int _DesplazamientoX;
        static private int _DesplazamientoY;
        const string _Titulo = "EL JUEGO DE LA VIDA: Damian Cabello";

        public JuegoVida()
        {
            TotalEjeX = 20;
            TotalEjeY = 40;
            DesplazamientoX = 20;
            DesplazamientoY = 3;
            Tablero = new sbyte[TotalEjeX, TotalEjeY];
            Contador = 0;
            DibujaMarco();
        }

        public JuegoVida(sbyte valorTotalEjeX, sbyte valorTotalEjeY, sbyte desplazamientoX, sbyte desplazamientoY)
        {
            TotalEjeX = valorTotalEjeX;
            TotalEjeY = valorTotalEjeY;
            DesplazamientoX = desplazamientoX;
            DesplazamientoY = desplazamientoY;
            Tablero = new sbyte[TotalEjeX, TotalEjeY];
            Contador = 0;
            DibujaMarco();
        }


        private static int DesplazamientoX
        {
            get { return _DesplazamientoX; }
            set { _DesplazamientoX = value; }
        }

        private static int DesplazamientoY
        {
            get { return _DesplazamientoY; }
            set { _DesplazamientoY = value; }
        }

        private static sbyte[,] Tablero
        {
            get { return _Tablero; }
            set { _Tablero = value; }
        }

        private static sbyte TotalEjeX
        {
            get { return _TotalEjeX; }
            set { _TotalEjeX = value; }
        }

        private static sbyte TotalEjeY
        {
            get { return _TotalEjeY; }
            set { _TotalEjeY = value; }
        }

        public uint Contador
        {
            get { return _Contador; }
            set { _Contador = value; }
        }

        public sbyte[,] CreaAleatorio()
        {
            Random rnd = new Random();

            for(sbyte i = 0; i < Tablero.GetLength(0); i++)
                for(sbyte j = 0; j < Tablero.GetLength(1); j++)
                    Tablero[i, j] = (sbyte)rnd.Next(2);

            return Tablero;
        }

        public void SiguienteIteracion()
        {
            sbyte[,] tableroAux = CopiaTablero();
            sbyte auxVecinas = 0;

            for(sbyte i = 0; i < Tablero.GetLength(0); i++)
                for(sbyte j = 0; j < Tablero.GetLength(1); j++)
                {

                    auxVecinas = CalcularVecinas(i, j);
                    //vivas
                    if(Tablero[i, j] == 1 && auxVecinas < 2 || Tablero[i, j] == 1 && auxVecinas > 3)
                        tableroAux[i, j] = 0;
                    //muertas
                    if(Tablero[i, j] == 0 && auxVecinas == 3)
                        tableroAux[i, j] = 1;
                }
            DibujarTableroString(EscribirTableroString(tableroAux));
            Tablero = tableroAux;
            Contador++;

        }

        public void MostrarTablero()
        {
            Console.SetCursorPosition(_DesplazamientoX + MARGENBORDE, _DesplazamientoY + MARGENBORDE);
            for(int i = 0; i < Tablero.GetLength(0); i++)
            {
                Console.CursorLeft = _DesplazamientoX + MARGENBORDE;
                for(int j = 0; j < Tablero.GetLength(1); j++)
                    if(Tablero[i, j] == 1)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                Console.WriteLine();
            }
        }

        private static sbyte[,] CopiaTablero()
        {
            sbyte[,] aux = new sbyte[Tablero.GetLength(0), Tablero.GetLength(1)];

            for(int i = 0; i < Tablero.GetLength(0); i++)
                for(int j = 0; j < Tablero.GetLength(1); j++)
                    aux[i, j] = Tablero[i, j];

            return aux;
        }

        private void DibujaMarco()
        {
            int auxDesplazamiento;
            if (DesplazamientoY >= 2)
            {
                Console.SetCursorPosition(Tablero.GetLength(1) / 2 - _Titulo.Length / 2 + 12, DesplazamientoY - 2);
                Console.WriteLine("EL JUEGO DE LA VIDA: Damian Cabello "); 
            }
            Console.SetCursorPosition(DesplazamientoX, DesplazamientoY);
            Console.Write('╔');
            for (int i = 0; i < Tablero.GetLength(1); i++)
                Console.Write('═');
            Console.Write("╗\n");
            for (int i = 0; i < Tablero.GetLength(0); i++)
            {
                auxDesplazamiento = 0;
                Console.CursorLeft = _DesplazamientoX;

                for(int j = 0; j <= Tablero.GetLength(1) + MARGENBORDE*2; j++)
                {
                    if(j == 0 || j == Tablero.GetLength(1) + MARGENBORDE*2)
                    {
                        Console.CursorLeft = auxDesplazamiento + DesplazamientoX;
                        Console.Write('║');
                    }
                    else
                        auxDesplazamiento++;
                }
                Console.WriteLine();
            }
            Console.CursorLeft = DesplazamientoX;
            Console.Write('╚');
            for (int i = 0; i < Tablero.GetLength(1); i++)
                Console.Write('═');
            Console.WriteLine('╝');

            if (DesplazamientoY < 2)
            {
                Console.SetCursorPosition(Tablero.GetLength(1)/2 - _Titulo.Length/2 + 12, DesplazamientoY  + Tablero.GetLength(0)+ 2);
                Console.Write(_Titulo);
            }

            Opciones(true);
        }

        private string[] EscribirTableroString(sbyte[,] m)
        {
            string[] aux = new string[m.GetLength(0)];
            for(sbyte i = 0; i < m.GetLength(0); i++)
            {
                for(sbyte j = 0; j < m.GetLength(1); j++)
                    if(Tablero[i, j] == 1)
                        aux[i] +="*";
                    else
                        aux[i] +=" ";
            }
            return aux;
        }

        private void DibujarTableroString(string[] a)
        {
            Console.SetCursorPosition(_DesplazamientoX + MARGENBORDE, _DesplazamientoY + MARGENBORDE);
            for(int i = 0; i < a.Length; i++)
            {
                Console.CursorLeft = _DesplazamientoX + MARGENBORDE;
                Console.WriteLine(a[i]);
            }
        }

        private sbyte CalcularVecinas(sbyte posX, sbyte posY)
        {
            int x = Tablero.GetLength(0) + posX;
            int y = Tablero.GetLength(1) + posY;
            sbyte totalX = (sbyte)Tablero.GetLength(0);
            sbyte totalY = (sbyte)Tablero.GetLength(1);

            sbyte vecinas = (sbyte)
                                             (Tablero[(x - 1) % totalX, (y - 1) % totalY] +
                                              Tablero[(x - 1) % totalX, (y)     % totalY] +
                                              Tablero[(x - 1) % totalX, (y + 1) % totalY] +
                                              Tablero[(x)     % totalX, (y - 1) % totalY] +
                                              Tablero[(x)     % totalX, (y + 1) % totalY] +
                                              Tablero[(x + 1) % totalX, (y - 1) % totalY] +
                                              Tablero[(x + 1) % totalX, (y)     % totalY] +
                                              Tablero[(x + 1) % totalX, (y + 1) % totalY]);

            return vecinas;
        }

        public void CreaTablero()
        {
            Tablero = new sbyte[Tablero.GetLength(0),Tablero.GetLength(1)];

            Console.CursorVisible = true;
            Console.CursorSize = 50;
            sbyte inicioX = (sbyte)(DesplazamientoX + MARGENBORDE);
            sbyte finX = (sbyte)(Tablero.GetLength(1) + DesplazamientoX);
            sbyte inicioY = (sbyte)(DesplazamientoY + MARGENBORDE);
            sbyte finY = (sbyte)(Tablero.GetLength(0) + DesplazamientoY);
            sbyte posActualX = inicioX;
            sbyte posActualY = inicioY;
            ConsoleKeyInfo tecla;
            DibujaMarco();
            Console.SetCursorPosition(inicioX, inicioY);
            do
            {
                tecla = Console.ReadKey(true);
                switch(tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        if(posActualY != inicioY)
                            posActualY--;
                        break;

                    case ConsoleKey.DownArrow:
                        if(posActualY != finY)
                            posActualY++;
                        break;

                    case ConsoleKey.LeftArrow:
                        if(posActualX != inicioX)
                            posActualX--;
                        break;

                    case ConsoleKey.RightArrow:
                        if(posActualX != finX)
                            posActualX++;
                        break;

                    case ConsoleKey.Enter:
                        Console.Write("x={0},y={1}", posActualX - DesplazamientoX - 1, posActualY - DesplazamientoY - 1);
                        Console.ReadKey();
                        Actualiza(posActualX, posActualY,true);
                        break;

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Tablero[posActualY - DesplazamientoY - MARGENBORDE, posActualX - DesplazamientoX - MARGENBORDE] = 1;
                        Console.Write('*');
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        CopiarFigura(spin_hor, (sbyte)(posActualY - DesplazamientoY - MARGENBORDE), (sbyte)(posActualX - DesplazamientoX - MARGENBORDE));
                        Actualiza(posActualX, posActualY,false);
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        CopiarFigura(spin_ver, (sbyte)(posActualY - DesplazamientoY - MARGENBORDE), (sbyte)(posActualX - DesplazamientoX - MARGENBORDE));
                        Actualiza(posActualX, posActualY, false);
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        CopiarFigura(barco, (sbyte)(posActualY - DesplazamientoY - MARGENBORDE), (sbyte)(posActualX - DesplazamientoX - MARGENBORDE));
                        Actualiza(posActualX, posActualY, false);
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        CopiarFigura(sapo, (sbyte)(posActualY - DesplazamientoY - MARGENBORDE), (sbyte)(posActualX - DesplazamientoX - MARGENBORDE));
                        Actualiza(posActualX, posActualY, false);
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        CopiarFigura(planeador, (sbyte)(posActualY - DesplazamientoY - MARGENBORDE), (sbyte)(posActualX - DesplazamientoX - MARGENBORDE));
                        Actualiza(posActualX, posActualY, false);
                        break;

                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        CopiarFigura(nave, (sbyte)(posActualY - DesplazamientoY - MARGENBORDE), (sbyte)(posActualX - DesplazamientoX - MARGENBORDE));
                        Actualiza(posActualX, posActualY, false);
                        break;

                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        CopiarFigura(diehard, (sbyte)(posActualY - DesplazamientoY - MARGENBORDE), (sbyte)(posActualX - DesplazamientoX - MARGENBORDE));
                        Actualiza(posActualX, posActualY, false);
                        break;

                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        CopiarFigura(acorn, (sbyte)(posActualY - DesplazamientoY - MARGENBORDE), (sbyte)(posActualX - DesplazamientoX - MARGENBORDE));
                        Actualiza(posActualX, posActualY, false);
                        break;

                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        Tablero[posActualY - DesplazamientoY - MARGENBORDE, posActualX - DesplazamientoX - MARGENBORDE] = 0;
                        Console.Write(' ');
                        Actualiza(posActualX, posActualY, false);
                        break;

                }
                Console.SetCursorPosition(posActualX, posActualY);
            } while(tecla.Key != ConsoleKey.Escape);
            do
            {
                SiguienteIteracion();
                Thread.Sleep(200);
            } while(!Console.KeyAvailable);


 
        }

        private void Actualiza(sbyte posActualX, sbyte posActualY,bool borrado)
        {
            if (borrado)
            {
                Console.Clear();
                DibujaMarco();
            }
            Console.SetCursorPosition(posActualX, posActualY);
            MostrarTablero();
        }

        private void Actualiza()
        {
            Console.Clear();
            DibujaMarco();
            MostrarTablero();
        }

        static void CopiarFigura(sbyte[,] figura, sbyte y, sbyte x)
        {
            sbyte fila, columna;
            sbyte ancho_fig = (sbyte)figura.GetLength(1);
            sbyte alto_fig = (sbyte)figura.GetLength(0);
            sbyte posx, posy;

            x = (sbyte)(x - (ancho_fig / 2));
            y = (sbyte)(y - (alto_fig / 2));

            for (fila = 0; fila < alto_fig; fila++)
            {
                for (columna = 0; columna < ancho_fig; columna++)
                {
                    posy = (sbyte)(y + fila);
                    posx = (sbyte)(x + columna);
                    if ((posy >= 0) && (posy < Tablero.GetLength(1)) && (posx >= 0) && (posx < Tablero.GetLength(1)))
                    {
                        Tablero[posy, posx] = figura[fila, columna];
                    }
                }
            }
        }

        private void Opciones(bool creativo)
        {
            string[] normalUI = { "[A]: Automatico.", "[C]: Crear tu juego.", "[I]: Itinerar", "[P]: Pausar", "[R]: Resetear.", "[V]: Vaciar tablero.", "[H]: Ayuda.", "",  "[ESC]: Salir." };
            string[] modoCreativoUI = {
                "OPCIONES CREATIVO:",
                "===========================",
                "[1]: Vida en celda.",
                "[2]: Crear spin horizontal.",
                "[3]: Crear spin vertical.",
                "[4]: Crear barco.",
                "[5]: Crear sapo.",
                "[6]: Crear planeador.",
                "[7]: Crear nave.",
                "[8]: Crear diehard.",
                "[9]: Crear acorn.",
                "[0]: Matar celda.",
                "[ENTER]: Ver coordenada.",
                "[ESC]: Continuar el juego." };

            for (int i = 0; i < normalUI.Length; i++)
            {
                Console.SetCursorPosition(10, DesplazamientoY + Tablero.GetLength(0) + 10 + i);
                Console.Write(normalUI[i]);
            }
            if (creativo)
            {
                for (int i = 0; i < modoCreativoUI.Length; i++)
                {
                    Console.SetCursorPosition(DesplazamientoX + Tablero.GetLength(1) +2, DesplazamientoY + i);
                    Console.Write(modoCreativoUI[i]);
                }

            }
        }

    }
}
