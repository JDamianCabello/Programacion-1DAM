using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_jugandoConTipos_Ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = (char)65;
            int i1 = 0;
            byte b1 = (byte)'A';
            short s1 = 5;  //5 decimal en binario es 0101 y en un short 16 bits es 0000 0000 0000 0101. En hexa es 0005.
            short s2 = 10; //10 decimal en binario es 1010 y en un short 16 bits es 0000 0000 0000 1010. En hexa es 000A.
            string texto1 = "hola";
            string texto2 = "hola";
            int[] a1 = { 1, 2, 3 };
            int[] a2 = { 1, 2, 3 };
            float f1 = 3.141592F; //No se queja por comvertirlo a float con la F del final.

            Console.WriteLine("El número s1 vale en decimal {0} y en hexadecimal {0:X4}", s1);
            Console.WriteLine("El número s2 vale en decimal {0} y en hexadecimal {0:X4}", s2);


            Console.WriteLine("El complemento A1 de {0} es {1}", s2, ~s2);
            Console.WriteLine("El complemento A1 de {0:X8} es {1:X8} -> {2:X8}", s2, ~s2,~~s2);

            Console.WriteLine("¿Es texto1 == a texto2? {0}",texto1==texto2);

            Console.WriteLine("¿Es a1 == a2? (comparando valor) {0}",a1 == a2);
            Console.WriteLine("¿Es a1 un array? (comparando referencia) {0}", a1 is Array);

            Console.WriteLine("texto1 + texto2 es {0}", texto1 + texto2);


            Console.ReadKey();
        }
    }
}
