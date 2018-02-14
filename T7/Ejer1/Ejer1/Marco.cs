using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    public enum TipoMarco { Básico, Cruz, Simple,Doble };

    public class Marco
    {
        uint _altoMax = (uint)Console.WindowHeight - 1;
        uint _largoMax = (uint)Console.WindowWidth - 2;

        public static string RecuadrosPorDefecto(TipoMarco tipoMarco, int altoRecuadro)
        {
            string tmp = string.Empty;
            switch (tipoMarco)
            {
                case TipoMarco.Básico:
                    tmp = Marco.PintaRecuadro('*', ' ', altoRecuadro, Console.WindowWidth - 2, 1);
                    break;
                case TipoMarco.Cruz:
                    tmp = Marco.PintaRecuadro('-', '|', ' ', '+', altoRecuadro, Console.WindowWidth - 2, 1);
                    break;
                case TipoMarco.Simple:
                    tmp = Marco.PintaRecuadro('─', '│', ' ', '┌', '┐', '└', '┘', altoRecuadro, Console.WindowWidth - 2, 1);
                    break;
                case TipoMarco.Doble:
                    tmp = Marco.PintaRecuadro('═', '║',' ', '╔', '╗', '╚', '╝',altoRecuadro, Console.WindowWidth - 2, 1);
                    break;
            }
            return tmp;
        }

        /// <summary>
        /// Devuelve un string con la forma de un cuadrado en consola.
        /// </summary>
        /// <param name="borde">El borde del recuadro</param>
        /// <param name="totalAlto">Alto del cuadrado</param>
        /// <returns></returns>
        public static string PintaRecuadro(int totalAlto, char borde)
        {
            string tmp = string.Empty;

            for (int i = 0; i < totalAlto; i++)
            {
                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    if (j == 0 || j == Console.WindowWidth - 1 || i == 0 || i == totalAlto - 1)
                        tmp += borde;
                    else
                        tmp += ' ';
                }
                tmp += "\n";
            }
            return tmp;
        }

        /// <summary>
        /// Devuelve un string con la forma de un cuadrado en consola.
        /// </summary>
        /// <param name="borde">El borde del recuadro</param>
        /// <param name="relleno">Caracter dentro del recuadro</param>
        /// <param name="totalAlto">Alto del cuadrado</param>
        /// <param name="largo">Largo del cuadrado</param>
        /// <param name="desplazamientoDerecha">Desplazamiento hacia la derecha del cuadrado</param
        /// <returns></returns>
        public static string PintaRecuadro(char borde, char relleno, int totalAlto,int largo, int desplazamientoDerecha)
        {
            string tmp = string.Empty;

            for (int i = 0; i < totalAlto; i++)
            {
                tmp += "".PadRight(desplazamientoDerecha, ' ');
                for (int j = 0; j < largo; j++)
                {
                    if (j == 0 || j == largo - 1 || i == 0 || i == totalAlto - 1)
                        tmp += borde;
                    else
                        tmp += relleno;
                }
                tmp += "\n";
            }
            return tmp;
        }

        /// <summary>
        /// Devuelve un string con la forma de un cuadrado en consola.
        /// </summary>
        /// <param name="borde">El borde del recuadro</param>
        /// <param name="relleno">Caracter dentro del recuadro</param>
        /// <param name="esquina">Caracter que ocupará las esquinas del cuadrado</param>
        /// <param name="totalAlto">Alto del cuadrado</param>
        /// <param name="largo">Largo del cuadrado</param>
        /// <param name="desplazamientoDerecha">Desplazamiento hacia la derecha del cuadrado</param>
        /// <returns></returns>
        public static string PintaRecuadro(char borde, char relleno,char esquina, int totalAlto, int largo, int desplazamientoDerecha)
        {
            string tmp = string.Empty;

            for (int i = 0; i < totalAlto; i++)
            {
                tmp += "".PadRight(desplazamientoDerecha, ' ');
                for (int j = 0; j < largo; j++)
                {
                    if (j == 0 || j == largo - 1 || i == 0 || i == totalAlto - 1)
                        if(i == 0 && j == 0 || i == totalAlto - 1 && j == 0||i == 0 && j == largo - 1|| i == totalAlto - 1 && j == largo - 1)
                            tmp += esquina;
                        else
                            tmp += borde;
                    else
                        tmp += relleno;
                }
                tmp += "\n";
            }
            return tmp;
        }


        /// <summary>
        /// Devuelve un string con la forma de un cuadrado en consola.
        /// </summary>
        /// <param name="bordeHorizontal">El caracter del borde superior/inferior del recuadro</param>
        /// <param name="bordeVertical">El caracter del borde izquierda/derecha del recuadro</param>
        /// <param name="relleno">Caracter dentro del recuadro</param>
        /// <param name="esquina">Caracter que ocupará las esquinas del cuadrado</param>
        /// <param name="totalAlto">Alto del cuadrado</param>
        /// <param name="largo">Largo del cuadrado</param>
        /// <param name="desplazamientoDerecha">Desplazamiento hacia la derecha del cuadrado</param>
        /// <returns></returns>
        public static string PintaRecuadro(char bordeHorizontal, char bordeVertical, char relleno, char esquina, int totalAlto, int largo, int desplazamientoDerecha)
        {
            string tmp = string.Empty;

            for (int i = 0; i < totalAlto; i++)
            {
                tmp += "".PadRight(desplazamientoDerecha, ' ');
                for (int j = 0; j < largo; j++)
                {
                    if (j == 0 || j == largo - 1 || i == 0 || i == totalAlto - 1)
                        if (i == 0 && j == 0 || i == totalAlto - 1 && j == 0 || i == 0 && j == largo - 1 || i == totalAlto - 1 && j == largo - 1)
                            tmp += esquina;
                        else
                            if (i == 0 || i == totalAlto - 1)
                                tmp += bordeHorizontal;
                            else
                                tmp += bordeVertical;
                    else
                        tmp += relleno;
                }
                tmp += "\n";
            }
            return tmp;
        }

        /// <summary>
        /// Devuelve un string con la forma de un cuadrado en consola.
        /// </summary>
        /// <param name="borde">El borde del recuadro</param>
        /// <param name="relleno">Caracter dentro del recuadro</param>
        /// <param name="esquina1">Esquina de la posición arriba-izquierda</param>
        /// <param name="esquina2">Esquina de la posición arriba-derecha</param>
        /// <param name="esquina3">Esquina de la posición abajo-izquierda</param>
        /// <param name="esquina4">Esquina de la posición abajo-derecha</param>
        /// <param name="totalAlto">Alto del cuadrado</param>
        /// <param name="largo">Largo del cuadrado</param>
        /// <param name="desplazamientoDerecha">Desplazamiento hacia la derecha del cuadrado</param>
        /// <returns></returns>
        public static string PintaRecuadro(char borde, char relleno, char esquina1,char esquina2,char esquina3,char esquina4, int totalAlto, int largo, int desplazamientoDerecha)
        {
            string tmp = string.Empty;

            for (int i = 0; i < totalAlto; i++)
            {
                tmp += "".PadRight(desplazamientoDerecha, ' ');
                for (int j = 0; j < largo; j++)
                {
                    if (j == 0 || j == largo - 1 || i == 0 || i == totalAlto - 1)
                        if (i == 0 && j == 0 || i == totalAlto - 1 && j == 0 || i == 0 && j == largo - 1 || i == totalAlto - 1 && j == largo - 1)
                            tmp += ObtenerEsquinaActual(j,i,totalAlto,largo,esquina1,esquina2,esquina3,esquina4);
                        else
                            tmp += borde;
                    else
                        tmp += relleno;
                }
                tmp += "\n";
            }
            return tmp;
        }

        /// <summary>
        /// Devuelve un string con la forma de un cuadrado en consola.
        /// </summary>
        /// <param name="bordeHorizontal">El caracter del borde superior/inferior del recuadro</param>
        /// <param name="bordeVertical">El caracter del borde izquierda/derecha del recuadro</param>
        /// <param name="relleno">Caracter dentro del recuadro</param>
        /// <param name="esquina1">Esquina de la posición arriba-izquierda</param>
        /// <param name="esquina2">Esquina de la posición arriba-derecha</param>
        /// <param name="esquina3">Esquina de la posición abajo-izquierda</param>
        /// <param name="esquina4">Esquina de la posición abajo-derecha</param>
        /// <param name="totalAlto">Alto del cuadrado</param>
        /// <param name="largo">Largo del cuadrado</param>
        /// <param name="desplazamientoDerecha">Desplazamiento hacia la derecha del cuadrado</param>
        /// <returns></returns>
        public static string PintaRecuadro(char bordeHorizontal, char bordeVertical, char relleno, char esquina1, char esquina2, char esquina3, char esquina4, int totalAlto, int largo, int desplazamientoDerecha)
        {
            string tmp = string.Empty;

            for (int i = 0; i < totalAlto; i++)
            {
                tmp += "".PadRight(desplazamientoDerecha, ' ');
                for (int j = 0; j < largo; j++)
                {
                    if (j == 0 || j == largo - 1 || i == 0 || i == totalAlto - 1)
                        if (i == 0 && j == 0 || i == totalAlto - 1 && j == 0 || i == 0 && j == largo - 1 || i == totalAlto - 1 && j == largo - 1)
                            tmp += ObtenerEsquinaActual(j, i, totalAlto, largo, esquina1, esquina2, esquina3, esquina4);
                        else
                           if (i == 0 || i == totalAlto - 1)
                            tmp += bordeHorizontal;
                           else
                            tmp += bordeVertical;
                    else
                        tmp += relleno;
                }
                tmp += "\n";
            }
            return tmp;
        }


        /// <summary>
        /// Método que devuelve en qué esquina esta el cuadrado
        /// </summary>
        /// <param name="posX">Posición actual del eje X.</param>
        /// <param name="posY">Posición actual del eje Y.</param>
        /// <param name="totalAlto">Altura máxima del cuadrado</param>
        /// <param name="largo">Ancho máximo del cuadrado</param>
        /// <param name="esquina1">Caracter de la esquina en la posición arriba-izquierda</param>
        /// <param name="esquina2">Caracter de la esquina en la posición arriba-derecha</param>
        /// <param name="esquina3">Caracter de la esquina en la posición abajo-izquierda</param>
        /// <param name="esquina4">Caracter de la esquina en la posición abajo-derecha</param>
        /// <returns></returns>
        private static char ObtenerEsquinaActual(int posX, int posY, int totalAlto, int largo,char esquina1, char esquina2, char esquina3, char esquina4)
        {
            if (posX == 0 && posY == 0)
                return esquina1;
            if (posX == largo - 1 && posY == 0)
                return esquina2;
            if (posX == 0 && posY == totalAlto - 1)
                return esquina3;
            else
                return esquina4;

        }
    }
}
