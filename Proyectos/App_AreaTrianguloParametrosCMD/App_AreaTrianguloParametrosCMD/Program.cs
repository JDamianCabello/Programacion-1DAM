using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AreaTrianguloParametrosCMD
{
    class Program
    {
        //Calculo el área del triángulo. Recibo parámetros desde la consola
        static void Main(string[] args)
        {
            if(args.Length == 1 && args[0] == @"\?")
            {
                Ayuda();
                return;
            }

            if(args[0].Length == 1)
                switch(Char.ToUpper(args[0][0]))
                {
                    case 'T':
                        if(args.Length >= 3)
                            try
                            {
                                Console.WriteLine("El área de un triángulo de base {0} y altura {1} es: {2}", args[1], args[2], AreaTriangulo(double.Parse(args[1]), double.Parse(args[2])));
                            }
                            catch
                            {
                                Ayuda("Alguno de los parámetros no es válido.", args);
                            }
                        else
                            Ayuda("Tipo de ERROR: Faltan parámetros");
                        break;
                    case 'C':
                        if(args.Length >= 2)
                            try
                            {
                                Console.WriteLine("El área de un círculo de radio {0} es: {1}", args[1], AreaCirculo(double.Parse(args[1])));
                            }
                            catch
                            {
                                Ayuda("Alguno de los parámetros no es válido.", args);
                            }
                        else
                            Ayuda("Tipo de ERROR: Faltan parámetros");
                        break;
                    case 'R':
                        if(args.Length >= 3)
                            try
                            {
                                Console.WriteLine("El área de un rectángulo de base {0} y altura {1} es {2}", args[1], args[2], AreaRectangulo(double.Parse(args[1]), double.Parse(args[2])));
                            }
                            catch
                            {
                                Ayuda("Alguno de los parámetros no es válido.",args);
                            }
                        else
                            Ayuda("Tipo de ERROR: Faltan parámetros");
                        break;
                }
            else
                Ayuda("El primer parámetro solo puede ser \"t\", \"c\" o \"r\". Se admiten también en mayúsculas.",args);
        }
        static double AreaTriangulo(double baase, double altura) 
        {
            return baase * altura / 2;
        }

        static double AreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        static double AreaRectangulo(double baase, double altura) 
        {
            return baase * altura;
        }

        static void Ayuda()
        {
            Console.Clear();
            Console.WriteLine("\n\nCalcula áreas.                                                         Ayuda:");
            Console.WriteLine("=================================================================================\n");
            Console.WriteLine("Sintaxis:    App_AreaTrianguloParametrosCMD tipoCalculo valorBase valorAltura\n\n");
            Console.WriteLine("             App_AreaTrianguloParametrosCMD.- Nombre de la aplicación");
            Console.WriteLine("                                tipoCalculo.- Define el tipo de calculo");
            Console.WriteLine("                                               ->  \"t\" Triángulo: 2 parametros   ");
            Console.WriteLine("                                               ->  \"c\"   Circulo: 1 parametro   ");
            Console.WriteLine("                                               ->  \"r\"Rectángulo: 2 parametro   ");
            Console.WriteLine("                                tipoCalculo acepta parámetros en mayúsculas.");
            Console.WriteLine("             App_AreaTrianguloParametrosCMD.- Nombre de la aplicación");
            Console.WriteLine("                                  valorBase.- Primer parámetro numerico doble 0.00");
            Console.WriteLine("                                valorAltura.- Segundo parámetro numerico doble 0.00");
        }

        static void Ayuda(string texto)
        {
            Console.Clear();
            Console.WriteLine("\n\nCalcula áreas.                                                         Ayuda:");
            Console.WriteLine("=================================================================================\n");
            Console.WriteLine("Sintaxis:    App_AreaTrianguloParametrosCMD tipoCalculo valorBase valorAltura\n\n");
            Console.WriteLine("             App_AreaTrianguloParametrosCMD.- Nombre de la aplicación");
            Console.WriteLine("                                tipoCalculo.- Define el tipo de calculo");
            Console.WriteLine("                                               ->  \"t\" Triángulo: 2 parametros   ");
            Console.WriteLine("                                               ->  \"c\"   Circulo: 1 parametro   ");
            Console.WriteLine("                                               ->  \"r\"Rectángulo: 2 parametro   ");
            Console.WriteLine("                                tipoCalculo acepta parámetros en mayúsculas.");
            Console.WriteLine("             App_AreaTrianguloParametrosCMD.- Nombre de la aplicación");
            Console.WriteLine("                                  valorBase.- Primer parámetro numerico doble 0.00");
            Console.WriteLine("                                valorAltura.- Segundo parámetro numerico doble 0.00");
            Console.WriteLine("\n\n" + texto);
        }

        static void Ayuda(string texto, string[] parametros)
        {
            Console.Clear();
            Console.WriteLine("\n\nCalcula áreas.                                                         Ayuda:");
            Console.WriteLine("=================================================================================\n");
            Console.WriteLine("Sintaxis:    App_AreaTrianguloParametrosCMD tipoCalculo valorBase valorAltura\n\n");
            Console.WriteLine("             App_AreaTrianguloParametrosCMD.- Nombre de la aplicación");
            Console.WriteLine("                                tipoCalculo.- Define el tipo de calculo");
            Console.WriteLine("                                               ->  \"t\" Triángulo: 2 parametros   ");
            Console.WriteLine("                                               ->  \"c\"   Circulo: 1 parametro   ");
            Console.WriteLine("                                               ->  \"r\"Rectángulo: 2 parametro   ");
            Console.WriteLine("                                tipoCalculo acepta parámetros en mayúsculas.");
            Console.WriteLine("             App_AreaTrianguloParametrosCMD.- Nombre de la aplicación");
            Console.WriteLine("                                  valorBase.- Primer parámetro numerico doble 0.00");
            Console.WriteLine("                                valorAltura.- Segundo parámetro numerico doble 0.00");
            Console.WriteLine("\n\n"+texto);
            Console.Write("Lista de parámetros introducidos:");
            for(int i = 1; i < parametros.Length; i++)
                Console.Write("\t" + parametros[i]);
        }
    }
}
