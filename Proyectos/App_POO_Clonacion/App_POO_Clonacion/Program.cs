using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------
using App_GestionDePersonas;

namespace App_POO_Clonacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona pOrigen = new Persona("Uno", "Uno", DateTime.Now, 2.0);
            Persona pCopia = (Persona)pOrigen.Clone();

            Console.WriteLine("[{0}]: " + pOrigen.ToString(), "pOrigen");
            Console.WriteLine("[{0}]: " + pCopia.ToString(),"pCopia ");

            Console.WriteLine("\n\nCambiamos el nombre de la copia para ver si se copian los datos:\n\n");
            pCopia.Nombre = "Pepito";
            Console.WriteLine("[{0}]: " + pOrigen.ToString(), "pOrigen");
            Console.WriteLine("[{0}]: " + pCopia.ToString(), "pCopia ");


            Console.ReadKey();
        }
    }
}
