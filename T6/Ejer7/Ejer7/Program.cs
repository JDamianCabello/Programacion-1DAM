using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isbns = { "847-210-262-9", "8478884459", "8498382661", "8498482661"};

            for(int i = 0; i < isbns.Length; i++)
            {
                
                if(ValidarISBN(isbns[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ISBN válido.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ISBN incorrecto.");
                }
                Console.ResetColor();
                Console.WriteLine("\n\n--------------------------\n");
                    
            }


            Console.ReadLine();

        }

        static bool ValidarISBN(string isbn)
        {
            string auxISBN = string.Empty;
            int suma = 0;
            sbyte prueba;
            sbyte control = 0;


            if(char.ToUpper((char)(isbn[isbn.Length - 1])) == 'X')
                control = 10;
            else
                control = Convert.ToSByte((sbyte)char.GetNumericValue(isbn[isbn.Length - 1]));
            isbn.Trim();
            for(int i = 0; i < isbn.Length - 1; i++)
                if(char.IsDigit(isbn[i]))
                    auxISBN += isbn[i];


            for(int i = 1; i <= auxISBN.Length; i++)
                suma += (int)char.GetNumericValue(auxISBN[i - 1]) * i;

            prueba = (suma % 11) > 9 ? (sbyte)10 : (sbyte)(suma % 11);

            Console.WriteLine("             ISBN: {0}", isbn);
            Console.WriteLine("Dígito de control: {0}",control);
            Console.WriteLine("             Suma: {0}", suma);
            Console.WriteLine("           Prueba: ¿{0} = {1}?", prueba, control);
            

            return prueba == control ? true : false;

        }
    }
}
