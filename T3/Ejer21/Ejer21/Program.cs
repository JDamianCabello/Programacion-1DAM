using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer21
{
    class Program
    {
        static void Main(string[] args)
        {
            Quinela(15,3);
            Console.ReadKey();
        }

        static void Quinela(int totalLineas, int totalValores)
        {
            double[] valores = new double[totalLineas];
            Random rnd = new Random();

            for (int i = 0; i < valores.Length; i++)
                valores[i] = rnd.Next(0, totalValores);
            Console.WriteLine("\t\t   GENERADOR DE QUINELAS");
            Console.WriteLine("\t\t   =====================");
            for (int i = 0; i < valores.Length; i++)
                if (valores[i]==0)
                    Console.WriteLine("{0,30}","X");
                else
                    Console.WriteLine("{0,30}", valores[i]);

            Console.WriteLine("\n\n");
            for (int i = 0; i < totalValores; i++)
            {
                double contador = 0;
                for (int j = 0; j < valores.Length; j++)
                    if (valores[j] == i)
                        contador++;
                if(i==0)
                    Console.WriteLine("\t\tEl número X aparece {0} veces. ({1:F0}%)", contador, contador / totalLineas * 100);
                else
                    Console.WriteLine("\t\tEl número {0} aparece {1} veces. ({2:F0}%)", i, contador, contador / totalLineas*100);
            }
        }

    }
}
