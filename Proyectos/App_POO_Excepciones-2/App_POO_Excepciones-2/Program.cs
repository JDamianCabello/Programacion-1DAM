using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Excepciones_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int denominador = 1;
            int numerador = 1;

            try
            {
                Console.Write("Denominador: ");
                denominador = int.Parse(Console.ReadLine());
                denominador = numerador / denominador;
            }
            catch(Exception e)
            {
                
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.TargetSite);
            }

            Console.ReadKey(true);
        }
    }
}
