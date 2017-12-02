/*-------------------------------------------------------
 * AUTOR: Damián Cabello
 * FECHA: 09/10/17
 * VERSIÓN: 1.0
 * DESCRIPCIÓN: Muestra varios formstos de salida del método que lee.
 *-----------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_FormatosDeSalida
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muestra un número de longitud 5 ajustado a la derecha.
            Console.WriteLine("Número {0,5}", 123);
            Console.WriteLine("Número {0,5}", 3);
            Console.WriteLine("Número {0,5}", 12);
            Console.ReadKey();
            Console.Clear();
            //Salida hexadecimal
            Console.WriteLine("Esta número en b10: {0:N} vale en hexa: {0,10:x}", 15);




            Console.ReadKey();
        }
    }
}
