using System;
using System.Collections.Generic;

namespace Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDePersonas muxaHentePremoh = new ListaDePersonas();
            muxaHentePremoh.AnadirPersonasAleatorias(500);

            muxaHentePremoh.ListarPaginado("Lista de Personitas");


            Console.ReadLine();

        }
    }

    class CrearPersonasAleatorias
    {
        static string[] nombres = { "Javier", "Raul", "Bilal", "Fran", "Manuel", "Eustaquio", "Eliseo", "Vyacheslav", "Ismael", "Sebas", "Ana", "Muzska", "Alejandro", "Chemita", "Agallas", "Muriel", "Homero" };
        static string[] apellidos = { "Miguel", "Amado", "Prieto", "Perez", "González", "Toro", "Roldán", "Moya", "Rivas", "Tilla", "Menta", "García", "Shylyayev", "Bueno", "Turbado", "Sánchez", "Perro", "Cobarde" };
        static double[] sueldos = { 123, 456, 768, 456, 1999, 2500, 467 };
        static Random rnd = new Random();

        #region Métodos

        public static Persona Crear()
        {
            Persona p = new Persona(CrearNombre(), CrearApellidos(), CrearFNac(), CrearSueldo());
            return p;
        }

        static string CrearNombre()
        {
            return nombres[rnd.Next(nombres.Length)];
        }

        static string CrearApellidos()
        {
            return apellidos[rnd.Next(apellidos.Length)] + " " + apellidos[rnd.Next(apellidos.Length)];
        }

        static DateTime CrearFNac()
        {
            DateTime fecha = new DateTime();
            fecha = DateTime.Now - TimeSpan.FromDays(rnd.Next(1, 365 * 20));
            return fecha;
        }

        static double CrearSueldo()
        {
            return sueldos[rnd.Next(sueldos.Length)];
        }

        #endregion
    }

    class ListaDePersonas
    {
        List<Persona> _personas = null;
        int _id = 100;

        public ListaDePersonas()
        {
            _personas = new List<Persona>();
        }



        /// <summary>
        /// Añade una persona aleatoria
        /// </summary>
        /// <returns></returns>
        public bool AnadirPersonaAleatoria()
        {
            Persona p = CrearPersonasAleatorias.Crear();
            p.Id = _id++;
            _personas.Add(p);
            return true;
        }

        public bool AnadirPersonasAleatorias(int nPersonas)
        {
            for (int i = 0; i < nPersonas; i++)
            {
                Persona p = CrearPersonasAleatorias.Crear();
                p.Id = _id++;
                _personas.Add(p);
            }

            return true;
        }

        public void Buscar(Persona p)
        {
            _personas.BinarySearch(p);
        }

        public void VerPersona(Persona p)
        {
            Console.WriteLine(p.ToString());
        }

        public bool BorrarPersona(Persona p)
        {
            _personas.Remove(p);
            return true;
        }

        public void ListarPaginado(string tituloDelListado)
        {
            ConsoleKey salirListado = ConsoleKey.Escape; //Para poder salir del listado cuando queramos
            int numeroLineasPorPagina = 20; //Máximo de líneas por página
            int numeroLineaActual = 0; //Contador de líneas
            int numeroPaginaActual = 1; //Contador de páginas
            int numeroPaginasDelListado = (int)Math.Ceiling((double)_personas.Count / (double)numeroLineasPorPagina);
            int anchoDelListado = 74;

            foreach (Persona pTmp in _personas)
            {
                if (numeroLineaActual == 0)
                //Centrar el título en la cabecera
                {
                    Console.Clear();
                    Console.CursorLeft = (anchoDelListado / 2) - (tituloDelListado.Length / 2);
                    Console.WriteLine(tituloDelListado);
                    Console.WriteLine("".PadRight(anchoDelListado + 6, '='));
                }

                //Mostrar el cuerpo
                Console.WriteLine(pTmp.ToString());
                numeroLineaActual++;

                //Mostrar pie
                if (numeroLineasPorPagina == numeroLineaActual && numeroPaginaActual != numeroPaginasDelListado)
                {
                    Console.WriteLine("".PadRight(anchoDelListado + 6, '='));
                    Console.WriteLine("[Esc Abortar listado]                        Página: {0}/{1}", numeroPaginaActual++, numeroPaginasDelListado);
                    numeroLineaActual = 0;

                    //Al pulsar Esc abortamos el paginado
                    if (Console.ReadKey(true).Key == salirListado)
                        return;
                }
            }

            //Última página
            Console.WriteLine("".PadRight(anchoDelListado + 6, '='));
            Console.WriteLine("FIN DEL LISTADO ...");
            Console.WriteLine("Intro para salir.                                            Página: {0}/{1}", numeroPaginaActual, numeroPaginasDelListado);
            Console.ReadLine();
        }
    }
    class Persona
    {

        int _id;
        string _nombre;
        string _apellidos;
        DateTime _fechaNacimiento;
        double _sueldo;



        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public double Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }


        public Persona(string nombre, string apellidos, DateTime fnac, double sueldo)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fnac;
            this.Sueldo = sueldo;
        }



        public override string ToString()
        {
            return " | " + Id.ToString().PadLeft(6, ' ') + " | " + Nombre.ToString().PadRight(15) + " | " + Apellidos.PadRight(30) + " | " + FechaNacimiento.ToShortDateString() + "|" + Sueldo.ToString().PadLeft(5) + "|";
        }

    }


}
