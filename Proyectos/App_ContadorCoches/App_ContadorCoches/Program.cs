using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ContadorCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            coche[] coches = new coche[100];

            for(int i = 0; i < rnd.Next(100); i++)
                coches[i] = new coche();

            Console.WriteLine("Por ahí hay {0} coches circulando",coche.Contador);
        }
    }

    class coche
    {
        public static int Contador = 0;

        public coche()
        {
            coche.Contador++;
        }

        public void BorrarCoche()
        {
            coche.Contador--;
        }
    }
}
