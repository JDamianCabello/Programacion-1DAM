using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_JugandoConTipos_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos algunas variables.
            float f1, f2, f3;
            int i1;
            byte b1, b2;
            Console.Clear();
            Console.WriteLine("Nombre de la clase del tipo");
            Console.WriteLine("El tipo int es un {0}", typeof(int));
            Console.WriteLine("El tipo float es un {0}", typeof(float));
            Console.WriteLine("El tipo byte es un {0}", typeof(byte));

            Console.WriteLine("\nEspacio ocupado en memoria....");
            Console.WriteLine("El tipo {0} ocupa {1} bytes en memoria","int",sizeof(int));
            Console.WriteLine("El tipo {0} ocupa {1} bytes en memoria", "float", sizeof(float));
            Console.WriteLine("El tipo {0} ocupa {1} bytes en memoria", "Double", sizeof(double));

            Console.WriteLine("\nInformación sobre los límites de los tipos:");
            Console.WriteLine("Los límites del tipo {0} son {1} - {2}","int",int.MinValue,int.MaxValue);
            Console.WriteLine("Los límites del tipo {0} son {1} - {2}", "double", double.MinValue, double.MaxValue);
            Console.WriteLine("Los límites del tipo {0} son {1} - {2}", "sbyte", sbyte.MinValue, sbyte.MaxValue);

            //Desbordamiento
            b1 = 254;
            unchecked //Da excepcion es checked y se desborda.
            {
                Console.WriteLine("El valor de {0} -> {1}", "b1", b1);
                b1++;
                Console.WriteLine("El valor de {0} -> {1}", "b1", b1);
                b1++;
                Console.WriteLine("El valor de {0} -> {1}", "b1", b1);//Se desborda pero el unchecked esta activo por defecto
            }


            //Ejemplo de casting
            char letra = 'x';
            i1 = 65;
            letra = (char)65;
            Console.WriteLine("\n");
            Console.WriteLine("EL UNICODE/ASCII de {0} -> {1}",letra,i1);
            Console.WriteLine("EL UNICODE/ASCII de {0} -> {1}", letra, (int)letra);
            Console.WriteLine("EL UNICODE/ASCII de {0} -> {1}", (char)i1, i1);

            Console.ReadKey();
           
        }
    }
}
