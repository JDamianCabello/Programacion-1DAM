using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double resultado = 0;

            Console.WriteLine("Resuelvo ecuaciones de segundo grado.");

            try
            {

                Console.Write("Indique a: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Indique b: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Indique c: ");
                c = double.Parse(Console.ReadLine());

                if (a != 0)
                {
                    //calculamos el restuldado de la primera etapa
                    resultado = Math.Pow(b, 2) - 4 * a * c;

                    Console.WriteLine("\nEl resultado positivo ha sido {0}", (-b + Math.Sqrt(resultado)) / (2 * a));
                    Console.WriteLine("El resultado negativo ha sido {0}", (-b - Math.Sqrt(resultado)) / (2 * a));
                }
                else
                {
                    Console.WriteLine("El coeficiente cuadratico debe ser diferente de 0");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Los valores introducidos no son correctos");
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR: Los valores son demasiado grandes");
            }
            catch
            {
                Console.WriteLine("ERROR: Algo raro ha pasado....");
            }
            finally
            {
                Console.ReadKey();
            }

           


            
        }
    }
}
