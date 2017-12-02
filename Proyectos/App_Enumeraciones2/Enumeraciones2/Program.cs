using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones2
{
    class Program
    {
        enum Dia { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado };

        static void Main(string[] args)
        {
            string[] teclas;
            teclas = Enum.GetNames(typeof(ConsoleKey));

            for(Dia dia = Dia.Lunes; dia <= Dia.Viernes; dia++)
                Console.WriteLine(dia.ToString());

            //Colores del sistema
            for(ConsoleColor color = ConsoleColor.Black; color <= ConsoleColor.Yellow; color++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(color.ToString());
                Console.ResetColor();
            }

            //Dos formas de escribir datos de una enum.
            Console.WriteLine(Enum.GetName(typeof(Dia),3));
            Console.WriteLine(((Dia)3).ToString());

            //Lista de constante
            Console.WriteLine(" Lista de dias ");
            foreach(string tmp in Enum.GetNames(typeof(Dia)))
                Console.Write("{0}\t",tmp);

            Console.WriteLine("LISTA DE TECLAS");
            foreach(string item in teclas)
                Console.Write("{0}\t", item);

            Console.WriteLine("Hay definidas {0} teclas.",teclas.Length);
        }
    }
}
