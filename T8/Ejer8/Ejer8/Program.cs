using System;
using System.IO;


namespace Ejer8
{
    class Program
    {
        /*
           Escribe un programa que conste de dos funciones CrearFichero(string fi) y ListarFichero(string fi) donde:
            a)  La primera función almacena en un fichero de texto (fi) los nombres y apellidos de los alumnos. En nombre
                del archivo se le pasa a la función al llamarla.
            b)  Muestra por pantalla el contenido del fichero (fi) pasado.

         */
        static void Main(string[] args)
        {
            if (args.Length != 1)
                Console.WriteLine("No hay ruta desde la que leer!");
            else
            {
                string[] alumno1 = { "Damian", "Cabello" };
                string[] alumno2 = { "Pepe", "Grillo" };

                CrearFichero(args[0], alumno1);
                CrearFichero(args[0], alumno2);

                Console.WriteLine(ListarFichero(args[0]));
            }
            Console.ReadKey();


        }

        static void CrearFichero(string fi)
        {
            if (!File.Exists(fi))
                File.Create(fi);

            string[] datos = new string[2];
            Console.Write("Dime el nombre del alumno: ");
            datos[0] = Console.ReadLine();
            Console.Write("Dime los apellidos del alumno: ");
            datos[1] = Console.ReadLine();
            File.AppendAllText(fi, datos[1] + ", " + datos[0] + "\n");
            Console.WriteLine("Persona añadida correctamente!");
        }

        static void CrearFichero(string fi, string[] datos)
        {
            if (!File.Exists(fi))
                File.Create(fi);

            File.AppendAllText(fi, datos[1] + ", " + datos[0] + "\n");
        }

        static string ListarFichero(string fi)
        {
            return File.ReadAllText(fi);
        }
    }
}
