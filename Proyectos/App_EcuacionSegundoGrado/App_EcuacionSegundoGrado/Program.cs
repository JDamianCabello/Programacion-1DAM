using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_EcuacionSegundoGrado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculo de ecuacion de 2 grado
            float a = 0F;
            float b = 0F;
            float c = 0F;
            float dentroRaiz = 0F;
            float resultadoPositivo = 0F;
            float resultadoNegativo = 0F;
            Console.WriteLine("Soy una maquina resolviendo ecuaciones de 2º grado");
            Console.WriteLine("==================================================");
            Console.Write("Dime el coeficiente A: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Dime el coeficiente B: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Dime el coeficiente C: ");
            c = float.Parse(Console.ReadLine());

            //Compruebo el coeficiente a
            if (a == 0)
            {
                //No hay solucion
                Console.WriteLine("Esta ecuación no tiene raices en R.");
            }
            else
            {
                //Calcular
                dentroRaiz = (float)Math.Pow(b, 2) - 4 * a * c;
                if (dentroRaiz < 0)
                {
                    //No hay solución
                    Console.WriteLine("Esta ecuación no tiene raices en R.");
                }
                else
                {
                    //Solucionar
                    resultadoPositivo = (-b + (float)Math.Sqrt(dentroRaiz)) / (2 * a);
                    resultadoNegativo = (-b - (float)Math.Sqrt(dentroRaiz)) / (2 * a);
                    Console.WriteLine("Los resultados son:");
                    Console.WriteLine("\tx1 = " + resultadoPositivo);
                    Console.WriteLine("\tx2 = " + resultadoNegativo);
                }
            }
            Console.ReadKey();
        }
    }
}
