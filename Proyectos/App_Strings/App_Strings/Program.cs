using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Damián";
            String s3 = new string('=',7); //Crea un array de n veces el char de la izquierda.
            string s4 = s1 + s3;
            string s2 = "Damián";

            Console.WriteLine("Un texto".PadLeft(33));
            Console.WriteLine(s1.PadLeft(33));
            Console.WriteLine(s3.PadLeft(33));

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine();

            char[] sep = {' ', ','};
            string[] palabras = s1.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            Console.ReadKey();
        }
    }
}
