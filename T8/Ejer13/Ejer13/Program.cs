using System;
using System.IO;

namespace Ejer13
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio = DateTime.Now;
            DateTime fin;
            string ruta = @"E:\Google Drive\Git\Programacion\T8\_txtRelacion\txtEjer13.txt";
            Console.CursorVisible = false;

            do
            {
                fin = DateTime.Now;
                Console.Clear();
                Console.WriteLine("Estas logueado en el sistema con el usuario: {0}",Environment.UserName);
                Console.WriteLine("                 Hora de entrada al sistema: {0}",inicio.ToLongTimeString());
                Console.WriteLine("            Tiempo total dentro del sistema: {0}", fin - inicio );

                Console.WriteLine("\n\nPulsa una tecla para salir del sistema....");
                System.Threading.Thread.Sleep(1000);
            } while (!Console.KeyAvailable);

            File.AppendAllText(ruta, "Fecha entrada:\t" + inicio.ToShortDateString() + "\tUsuario:\t" + Environment.UserName + "\tFecha de salida:\t" + fin.ToShortDateString() + "\tHora de entrada:\t" + inicio.ToLongTimeString() + "\tHora de salida:\t" + fin.ToLongTimeString() + "\tTiempo dentro del sistema:\t" + (fin - inicio)+"\n");
        }
    }
}
