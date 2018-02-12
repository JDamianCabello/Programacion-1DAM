using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_EjemploIPresentable
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo(10, 2.3);
            Proveedor p = new Proveedor("Cristobal", "Javier", 101);
            t.OnPresentar += t_OnPresentar;

            VerDatos(t);

            Console.ResetColor();

            VerDatos(p);


            Console.ReadKey();
        }

        static void t_OnPresentar(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        static void VerDatos(IPresentable p)
        {
            p.Presentar();
            Console.WriteLine("-----------------------------");
        }
    }
}
