using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer12
{
    public class CartaInventadaException : Exception { }
    class Program
    {
        public enum palo {Oro = 1 , Basto, Copa, Espada };

        public struct Carta
        {
            public Carta(palo unPalo, sbyte num)
            {
                _palo = unPalo;
                _numero = num;
                _noSacada = true;
            }

            palo _palo;
            sbyte _numero;
            bool _noSacada;


            public bool NoSacada
            {
                get { return _noSacada; }
                set { _noSacada = value; }
            }

            public override string ToString()
            {
                switch (_numero)
                {
                    case 10: return "Sota de " + _palo.ToString();
                    case 11: return "Caballo de " + _palo.ToString();
                    case 12: return "Rey de " + _palo.ToString();

                }
                return _numero + " de " + _palo.ToString();
            }


        }

        static void Main(string[] args)
        {
            Carta[] baraja = CreaBaraja(40);
            int contador = 1;
            bool flag;
            ConsoleKeyInfo tecla;
            Console.CursorVisible = false;

            
            do
            {
                flag = true;
                Console.WriteLine("Pulsa una tecla para sacar cartas. Al final puedes pulsar 'S' para resetear.");
                do
                {
                    Console.WriteLine("[{0,2}] -> {1}", contador++, CartaAlea(baraja));
                    tecla = Console.ReadKey(true);
                } while (contador <= 40);

                do
                {
                    Console.CursorTop = 42;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Juego acabado. Volver a empezar? S/n");
                    tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.S)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Iniciando un nuevo juego....");
                        Console.ResetColor();
                        ReseteaBaraja(baraja);
                        contador = 1;
                        flag = false;
                    }
                    else
                        if (tecla.Key == ConsoleKey.N)
                            flag = false;
                        else
                            Console.WriteLine("Solo se aceptan las teclas 'S' o 'N'.");
                } while (flag);
            } while (tecla.Key == ConsoleKey.S);
        }

        static Carta[] CreaBaraja(sbyte total)
        {
            Carta[] unaBaraja = new Carta[total];
            Carta unaCarta;
            sbyte contador = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    unaCarta = new Carta((palo)i, (sbyte)j);
                    unaBaraja[contador++] = unaCarta;
                }
                for (int j = 10; j <= 12; j++)
                {
                    unaCarta = new Carta((palo)i, (sbyte)j);
                    unaBaraja[contador++] = unaCarta;
                }
            }

            return unaBaraja;
        }

        static Carta CartaAlea(Carta[] baraja)
        {
            Random random = new Random();
            bool flag = false;
            int aux = 0;
            Carta unaCarta;
            do
            {
                aux = random.Next(0, baraja.Length);
                unaCarta = baraja[aux];
                if (unaCarta.NoSacada)
                {
                    baraja[aux].NoSacada = false;
                    flag = true;
                }
            } while (!flag);

            return unaCarta;
        }

        static bool TodasSacadas(Carta[] baraja)
        {
            for (int i = 0; i < baraja.Length; i++)
                if (baraja[i].NoSacada == false)
                    return false;
            return true;
        }

        static void ReseteaBaraja(Carta[] baraja)
        {
            for (int i = 0; i < baraja.Length; i++)
                baraja[i].NoSacada = true;
        }

    }
}
