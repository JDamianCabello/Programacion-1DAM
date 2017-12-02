using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_IntroduccionTipos
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 5;
            object rNumero;
            rNumero = numero;                       //Boxing al tratar rNumero como int.

            Console.WriteLine((int)rNumero+10);     //Unboxing al hacer un casting de object a int

            object texto = "Hola caracola";
            Console.WriteLine(texto);

            Console.ReadLine();
        }
    }
}
