/*-------------------------------------------------------
 * AUTOR: Damián Cabello
 * FECHA: 09/10/17
 * VERSION: 1.0
 * DESCRIPCION: Calcula el área de un triángulo.
 *-----------------------------------------------------*/

using System;

namespace App_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string separador = "================================================";
            double baase = 0;
            double altura = 0;

            Console.Clear(); //Borramos la pantalla por si hay algo ya en esta.
            Console.WriteLine("\n\n" + separador);
            Console.WriteLine("\tCALCULO DEL AREA DEL TRIANGULO");
            Console.WriteLine(separador+"\n");

            Console.Write("\tDime la base: ");
            baase = double.Parse(Console.ReadLine());
            Console.Write("\tDime la altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\tEl área del triángulo de base: {0} y altura: {1} es: {2}",baase, altura, baase*altura/2);

            Console.CursorVisible = false;
            Console.Write("\n\n\nPulsa una tecla para salir.");
            Console.ReadKey();
            Console.CursorVisible = true;
        }
    }
}
