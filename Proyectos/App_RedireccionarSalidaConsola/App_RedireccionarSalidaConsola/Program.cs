using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_RedireccionarSalidaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ruta al fichero de salida.
            string ruta = @"c:\basura\salida.txt";

            Console.WriteLine("Escribiendo en la pantalla....");

            //Crear un flujo para conectarlo a la salida.
            FileStream fs = new FileStream(ruta, FileMode.Create);


            TextWriter tmp = Console.Out; //Aqui cambiamos el flujo de la pantalla al fichero.

            StreamWriter sw = new StreamWriter(fs);

            Console.SetOut(sw); //Este método necesita un TextWriter, como StreamWriter hereda del mismo, se lo podemos pasar (Esto es debido al polimorfismo).

            //Escribimos información de salida la cual irá al fichero.
            Console.WriteLine("Tengo sueño! D:");
            Console.WriteLine("Fecha: {0}   Hora: {1}",DateTime.Now.ToLongDateString(), DateTime.Now.ToShortTimeString());


            //Restauramos los valores de entrada, volviendo a tener el flujo en la consola.
            Console.SetOut(tmp);
            Console.WriteLine("Has vuelto a la consola.....");


            //Cerramos los flujos
            sw.Dispose();
            Console.ReadKey();
        }
    }
}
