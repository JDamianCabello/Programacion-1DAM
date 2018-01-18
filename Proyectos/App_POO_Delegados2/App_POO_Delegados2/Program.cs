using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Delegados2
{
    class Program
    {
        delegate void MiDelegado();

        static void Main(string[] args)
        {
            MiDelegado llamadaAVarios = M1;
            llamadaAVarios += M2;
            llamadaAVarios += M3;

            //llama a los métodos M1,M2,M3
            llamadaAVarios();


            //Ver cuantos métodos hay en la lista
            Console.WriteLine("\n\nHay {0} métodos en la lista.\n\n", llamadaAVarios.GetInvocationList().GetLength(0));
            //Quitamos M1, solo llamará a M2 y M3
            llamadaAVarios -= M1;
            llamadaAVarios();

            //Volvemos a ver cuantos métodos hay en la lista
            Console.WriteLine("\n\nHay {0} métodos en la lista.\n\n", llamadaAVarios.GetInvocationList().GetLength(0));
            Console.ReadKey();
        }

        static void M1()
        {
            Console.WriteLine("Soy M1");
        }

        static void M2()
        {
            Console.WriteLine("Soy M2");
        }

        static void M3()
        {
            Console.WriteLine("Soy M3");
        }
    }
}
