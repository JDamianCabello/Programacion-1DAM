using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f = new Factura();
            Pila p = new Pila();

            Copiar(f);
            Copiar(p);


            Console.ReadKey();
        }

        static void Copiar(ICloneable objeto)
        {
            //if(objeto is Factura) El operador is debuelve un bool, true si es del mismo tipo, false en caso contrario.

            Console.WriteLine(objeto.Clone());
        }
    }

    class Factura:ICloneable
    {
        public object Clone()
        {
            Console.WriteLine("Soy Factura.Clonar()");
            return null;
        }
    }

    class Pila:ICloneable
    {
        public object Clone()
        {
            Console.WriteLine("Soy Pila.Clonar()");
            return null;
        }
    }
}
