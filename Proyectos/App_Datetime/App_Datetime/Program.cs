using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;

            fecha = DateTime.Now;
            Console.WriteLine("Fecha de hoy: {0}",fecha.ToLongDateString());
            Console.WriteLine("Hora de hoy: {0}",fecha.ToLongTimeString());

            Console.WriteLine("\n\n   Conexión: "+fecha.Millisecond);
            Console.WriteLine("Estas dentro pulsa una tecla para salir.");
            Console.ReadKey();
            Console.WriteLine("\n\nDesconexión: " + DateTime.Now.Millisecond);



            Console.ReadKey();
        }
    }
}
