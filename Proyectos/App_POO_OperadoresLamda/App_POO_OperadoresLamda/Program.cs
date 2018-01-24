using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_OperadoresLamda
{
    class Program
    {
        delegate int dlgCuadrado(int x);

        static void Main(string[] args)
        {
            int numero = 30;


            //C# 1.0 Uso de delegados.
            Console.WriteLine("\n--- C# 1.0: Uso de delegados ---");

            //Creo una instancia del delegado asignada a cuadrado.
            dlgCuadrado dlg1 = new dlgCuadrado(Cuadrado);

            //Llamamos al delegado y le pasamos un valor.
            Console.WriteLine("\t{0}\n", dlg1(numero));


            //C# 2.0 Delegados con código de inicialización (met.Anónimo).
            Console.WriteLine("\n--- C# 2.0: Uso de delegados con código de inicialización ---");

            //Creo una instancia del delegado y le digo su método.
            dlgCuadrado dlg2 = delegate(int x)
            {
                return x * x;
            };

            //Escribimos el valor.
            Console.WriteLine("\t{0}\n", dlg2(numero));


            //C# 3.0 Delegados con expresión lamda.
            Console.WriteLine("\n--- C# 3.0: Uso de delegados con expresión Lamda ---");

            //Creo una instancia del delegado con operadores Lamda.
            dlgCuadrado dlg3 = x => x * x;

            //Escribimos el valor.
            Console.WriteLine("\t{0}\n", dlg3(numero));


            //Siguientes versiones. Se puede crear un delegado genérico
            //C# 3.0 Delegado genérico con expresión lamda.
            Console.WriteLine("\n--- C# 3.0: Uso de delegados genéricos con expresión Lamda ---");

            //Creo una instancia del delegado genérica.
            Func<int, int> dlg4 = x => x * x;

            //Escribimos el valor.
            Console.WriteLine("\t{0}\n", dlg4(numero));

            Console.ReadLine();



        }

        static int Cuadrado(int x)
        {
            return x * x;
        }
    }
}
