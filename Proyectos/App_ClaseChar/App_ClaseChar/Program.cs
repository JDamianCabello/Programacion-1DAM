using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ClaseChar
{
    class Program
    {
        static void Main(string[] args)
        {
            byte posIni = 32;
            byte posFin = 126;
            char caracter = ' ';

            for(byte i = posIni; i <= posFin; i++)
            {
                caracter = (Char)i;
                if(Char.IsControl(caracter))
                    Console.WriteLine("Control: {0}", caracter);
                if(Char.IsDigit(caracter))
                    Console.WriteLine("Dígito: {0}", caracter);
                if(Char.IsLetter(caracter))
                    Console.WriteLine("Letra: {0}", caracter);
                if(Char.IsNumber(caracter))
                    Console.WriteLine("Número: {0}", caracter);
            }

            Console.ReadKey();
            
        }
    }
}
