using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer19
{
    class Program
    {
        struct DatosPersona
        {
            string apellido;
            string nombre;
            string telf;

            public DatosPersona(string nombre, string apellido, string telf)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.telf = telf;
            }

            public override string ToString()
            {
                return nombre.PadLeft(30) + apellido.PadLeft(30) + telf.PadLeft(15);
            }

        }
        static Dictionary<int, DatosPersona> dicionario = new Dictionary<int, DatosPersona>();
        static int id;

        static void Main(string[] args)
        {
            id = 1;
            do
            {
            } while (UIMenu().Key != ConsoleKey.Escape);
        }

        static ConsoleKeyInfo UIMenu()
        {
            ConsoleKeyInfo tecla;
            int aux = 0;
            Console.Clear();
            Console.WriteLine("      MENU DE GESTION");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Añadir ficha aleatoria.");
            Console.WriteLine("2. Añadir N fichas aleatorias.");
            Console.WriteLine("3. Listar fichas.");
            tecla = Console.ReadKey(true);
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    AnadirFichasAlea(1);
                    Console.WriteLine("Se añadió correctamente... Pulsa una tecla para volver al menú.");
                    Console.ReadKey();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.Write("Introduce el total de fichas a añadir: ");
                    aux = int.Parse(Console.ReadLine());
                    AnadirFichasAlea(aux);
                    Console.WriteLine("Se añadieron {0} fichas correctamente. Pulsa una tecla para volver al menú.", aux);
                    Console.ReadKey();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Listado();
                    Console.WriteLine("FIN... Pulsa una tecla para volver al menú.");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
            return tecla;
        }


        static void Listado()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("LISTADO:\n");
            Console.WriteLine("NOMBRE".PadLeft(30) + "APELLIDOS".PadLeft(35) + "TELÉFONO".PadLeft(15));
            Console.WriteLine("===================================================================================");
            Console.ResetColor();


            foreach (var item in dicionario)
            {
                Console.Write("[{0}]: ", item.Key.ToString().PadLeft(2));
                Console.WriteLine(item.Value.ToString());
            }


        }


        static void AnadirFichasAlea(int nFichas)
        {
            string[] nombres = { "Raul", "Bilal", "Fran", "Manuel", "Ignacio", "Eustaquio", "Eliseo", "Aitor", "Vyacheslav", "Ismael", "Sebas", "Ana", "Muzska", "Rubén", "Alejandro" };
            string[] apellidos = { "Prieto", "Perez", "González", "Toro", "Roldán", "Moya", "Rivas", "Tilla", "Menta", "García", "Shylyayev", "Bueno", "Turbado", "Sánchez", "Zúñiga" };

            Random rnd = new Random();
            string tlfn = "";

            for (int i = 0; i < nFichas; i++)
            {
                tlfn = rnd.Next(600000000, 799999999).ToString();
                DatosPersona tmp = new DatosPersona(nombres[rnd.Next(0, nombres.Length - 1)], apellidos[rnd.Next(0, apellidos.Length - 1)], tlfn);
                dicionario.Add(id++, tmp);
            }

        }
    }
}
