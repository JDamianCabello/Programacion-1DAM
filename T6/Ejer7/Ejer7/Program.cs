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
            Console.WriteLine(ValidarISBN("847-210-262-9"));
            Console.WriteLine(ValidarISBN("8421728030124"));

        }

        static bool ValidarISBN(string isbn)
        {
            string auxISBN = string.Empty;
            int suma = 0;
            char prueba;
            char control = isbn[isbn.Length - 1];

            for(int i = 0; i < isbn.Length - 1; i++)
                if(char.IsDigit(isbn[i]))
                    auxISBN += isbn[i];



            for(int i = 1; i < auxISBN.Length - 1; i++)
                suma += (int)char.GetNumericValue(auxISBN[i - 1]) * i;

            prueba = (suma %= 11) > 9 ? 'X' : (char)(suma %= 11);
            Console.WriteLine(auxISBN);
            Console.WriteLine("Prueba {0}", prueba);
            Console.WriteLine("suma {0}", suma);
            return prueba == control ? true : false;

        }
    }
}
