using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_IntroExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo = 0;
            int divisor = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("soy una maquina dividiendo.");
                    Console.Write("Dime el dividendo: ");
                    dividendo = int.Parse(Console.ReadLine());
                    Console.Write("\nDime el divisor: ");
                    divisor = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado de {0} / {1} es {2}", dividendo, divisor, dividendo / divisor);
                    break;
                }
                catch(OverflowException e)
                {
                    Console.WriteLine("El número introducido es demasiado grande para un entero.");
                }
                catch(FormatException e)
                {
                    Console.WriteLine("La cadena introducida no tiene el formato correcto.");
                }
                catch(ArgumentNullException e)
                {
                    Console.WriteLine("La cadena introducida está vacia.");
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("El divisor no puede ser 0.");
                }
                catch
                {
                }
            } while(true);
        }
    }
}
