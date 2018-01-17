using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer16
{
    enum Categoria { Aprendiz, Peon, Encargado, Gerente };

    struct Ficha
    {

        // Campos
        string dni;
        string nombre;
        DateTime fechaNacimiento;
        Categoria categoria;
        // etc.


        // Constructor. Firma: public
        public Ficha(string dni, string nombre, DateTime fechaNacimiento, Categoria categoria)
        {
            // El dni string, es el dni que le pases, al parámetro del constructor.
            this.dni = dni;
            if (nombre.Length > 27)
                this.nombre = nombre.Substring(0, 25) + "...";
            else
                this.nombre = nombre;
            this.categoria = categoria;
            this.fechaNacimiento = fechaNacimiento;

        }

        public string GetDni()
        {
            return dni;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public DateTime GetDateTime()
        {
            return fechaNacimiento;
        }
        public Categoria GetCategoria()
        {
            return categoria;
        }
    }



    class Program
    {
        static List<Ficha> FicheroEmpleados = new List<Ficha>();
        static void Main(string[] args)
        {
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
                    AnadirFichasAlea(1, FicheroEmpleados);
                    Console.WriteLine("Se añadió correctamente... Pulsa una tecla para volver al menú.");
                    Console.ReadKey();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.Write("Introduce el total de fichas a añadir: ");
                    aux = int.Parse(Console.ReadLine());
                    AnadirFichasAlea(aux, FicheroEmpleados);
                    Console.WriteLine("Se añadieron {0} fichas correctamente. Pulsa una tecla para volver al menú.",aux);
                    Console.ReadKey();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    ListarEmpleados(FicheroEmpleados);
                    Console.WriteLine("FIN... Pulsa una tecla para volver al menú.");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
            return tecla;
        }


        static void ListarEmpleados(List<Ficha> empleados)
        {
            // Muestra por panrtalla un listado de empleados.
            // Parte de la cabecera del listado
            Console.WriteLine("Listado d empleados:");
            Console.WriteLine("".PadRight(70, '='));
            Console.Write("DNI".PadRight(10, ' '));
            Console.Write("NOMBRE".PadRight(30, ' '));
            Console.Write("FECHA DE NAC.".PadRight(11, ' '));
            Console.Write("CATEGORIA");
            Console.WriteLine();
            Console.Write("".PadRight(70, '='));
            Console.WriteLine();
            //------------------------------------
            foreach (Ficha tmp in empleados)
            {
                Console.Write(tmp.GetDni().PadRight(10, ' '));
                Console.Write(tmp.GetNombre().PadRight(30, ' '));
                Console.Write(tmp.GetDateTime().ToShortDateString().PadRight(11, ' '));
                Console.Write(tmp.GetCategoria().ToString());
                Console.WriteLine();
            }
            Console.WriteLine("\n\n No hay más datos a listar...");
            Console.ReadLine();
        }

        static int BuscarFicha(Ficha ficha, List<Ficha> lista)
        {
            if (ficha.GetDni().Length == 0)
            {
                return int.MaxValue;
            }
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].GetDni() == ficha.GetDni())
                {
                    return i;
                }

            }
            return -1;
        }

        static bool AnadirFicha(Ficha f, List<Ficha> lista)
        {
            int pos = BuscarFicha(f, lista);
            if (pos != -1)
            {
                return false;
            }
            lista.Add(f);
            return true;
        }

        static void AnadirFichasAlea(int nFichas, List<Ficha> lista)
        {
            string[] nombres = { "Pepe", "En un lugar de la Mancha de cuyo", "Encarna", "Ramón", "Eliseo", "Lourdes", "Chan" };
            Random rnd = new Random();
            char letraDni = ' ';
            string dni = "";

            for (int i = 0; i < nFichas; i++)
            {
                letraDni = (char)rnd.Next((int)'A', (int)'Z' + 1);
                dni = rnd.Next(1000000, 9999999).ToString() + letraDni;
                Ficha tmp = new Ficha(dni, nombres[rnd.Next(nombres.Length)], DateTime.Now.AddDays(rnd.Next(12121)), (Categoria)rnd.Next(4));
                AnadirFicha(tmp, lista);
            }

        }

    }

}
