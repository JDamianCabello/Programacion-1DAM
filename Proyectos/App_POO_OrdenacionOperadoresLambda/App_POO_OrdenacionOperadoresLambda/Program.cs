using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_OrdenacionOperadoresLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 3, 4, 77, 12, 67, 90, 22, 99, 21, 0 };
            string[] nombres = { "pepe", "dani", "juan", "paco", "Antonio" };

            //Expresión lambda que evalua si el valor es PAR.

            Console.WriteLine("En el array hay {0} números PARES", numeros.Count<int>(n => n % 2 == 0));

            /*
             * EXPLICACIÓN: numeros.Count<int>(n => n % 2 == 0);
             * 
             *  n es el valor que obtiene del array, la propiedad count lo recorre automáticamente ya.
             *  n % 2 == 0 es un boolean y es el tipo que devuelve (y el criterio para contar en este caso)
             *  
             * Al final devuelve el total de veces que aparece o se dá el criterio de búsqueda en la coleccióne
             */

            UnMetodo(nombres, delegate(string nombre)
            {
                return nombre.ToLower() == "Juan".ToLower();
            });

            //La llamada al método podría ser así....

            UnMetodo(nombres, n => n.ToLower() == "juan".ToLower());

            Console.ReadKey();


        }
        
        static void UnMetodo(string[] nombres, Func<string, bool> miExpresion)
        {
            Console.WriteLine("Uso de Lambda con método anónimo");

            foreach(string tmp in nombres)
                if(miExpresion(tmp))
                    Console.WriteLine("Encontrado: {0}",tmp);
        }

    }
}
