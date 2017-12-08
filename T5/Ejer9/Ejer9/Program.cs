using System;
using System.Threading;


namespace Ejer9
{
    class Program
    {
        public struct Persona
        {
            uint _id;
            string _nombre;
            string _dni;
            sbyte _edad;
            uint _sueldo;
            DateTime _fechaContrato;
            bool _borrada;

            public bool Borrada
            {
                get { return _borrada; }
                set { _borrada = value; }
            }

            public string Nombre
            {
                get { return _nombre; }
                set { _nombre = value; }
            }

            public uint Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string Dni
            {
                get { return _dni; }
                set { _dni = value; }
            }

            public Persona(string nombre, string dni, sbyte edad, uint sueldo, DateTime fcontrato, uint id)
            {
                _id = numId;
                _nombre = nombre;
                _dni = dni;
                _edad = edad;
                _sueldo = sueldo;
                _fechaContrato = fcontrato;
                _id = id;
                _borrada = false;

            }

            public override string ToString()
            {
                string aux = string.Empty;
                aux += "=====================================================================\n";
                aux += "            id: " + _id.ToString() + ".\n";
                aux += "        Nombre: " + _nombre.ToString() + ".\n";
                aux += "           DNI: " + _dni.ToString() + ".\n";
                aux += "          Edad: " + _nombre.ToString() + ".\n";
                aux += "        Sueldo: " + _sueldo.ToString() + ".\n";
                aux += "Fecha Contrato: " + _fechaContrato.ToShortDateString() + ".\n";
                return aux;
            }
        }
        static Persona[] listado = new Persona[200];
        static uint nDatos;
        static uint numId = 1;

        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            string aux = string.Empty;
            int[] auxArray;
            uint auxUInt = 0;
            int auxINT = 0;

            do
            {
                Console.Clear();
                UIMenu();
                tecla = Console.ReadKey(true);
                Console.Clear();
                switch (tecla.Key)
                {
                    case ConsoleKey.D1: case ConsoleKey.NumPad1:
                        Console.WriteLine("AÑADIR PERSONA");
                        Console.WriteLine("=================================");
                        CreaPersona();
                        Console.WriteLine("Persona creada y añadida. pulsa una tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2: case ConsoleKey.NumPad2:
                        Console.WriteLine("AÑADIR PERSONAS ALETORIAS");
                        Console.WriteLine("=================================");
                        Console.Write("Introduzca cuantas personas quiere añadir: ");
                        auxUInt = uint.Parse(Console.ReadLine());
                        if(CreaPersonasAlea((int)auxUInt))
                            Console.WriteLine("Personas creadas y añadidas, pulsa una tecla para volver al menú...");
                        else
                            Console.WriteLine("No hay espacio, pruebe a incrementar el array....Pulsa una tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3: case ConsoleKey.NumPad3:
                        Console.WriteLine("BUSCAR PERSONAS");
                        Console.WriteLine("=================================");
                        Console.WriteLine("Indica que persona quieres buscar: ");
                        Console.WriteLine("1. Buscar por ID.");
                        Console.WriteLine("2. Buscar por nombre");
                        Console.WriteLine("3. Buscar por DNI");
                        tecla = Console.ReadKey(true);
                        switch (tecla.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Write("\nIntroduzca el id a buscar: ");
                                auxUInt = uint.Parse(Console.ReadLine());
                                if (BuscaPorID(auxUInt) == -1)
                                    Console.WriteLine("El id {0} no existe en la colección.Pulsa una tecla para volver al menú.", auxUInt);
                                else
                                {
                                    Console.WriteLine("Mostrando los datos de la persona: ");
                                    Console.WriteLine(listado[BuscaPorID(auxUInt)].ToString());
                                }
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Write("\nIntroduce el/los nombre/s a buscar: ");
                                aux = Console.ReadLine();
                                auxArray = BuscaPorNombre(aux);
                                if (auxArray[0] == -1)
                                    Console.WriteLine("El nombre {0} no existe en la colección.Pulsa una tecla para volver al menú.", aux);
                                else
                                {
                                    Console.WriteLine("Mostrando los datos de búsqueda: ");
                                    for (int i = 0; i < auxArray.Length; i++)
                                        Console.WriteLine(listado[auxArray[i]]);
                                }

                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Write("\nIntroduzca el DNI a buscar: ");
                                aux = Console.ReadLine();
                                if (BuscaPorDNI(aux) == -1)
                                    Console.WriteLine("El DNI {0} no existe en la colección.Pulsa una tecla para volver al menú.", aux);
                                else
                                {
                                    Console.WriteLine("Mostrando los datos de la persona: ");
                                    Console.WriteLine(listado[BuscaPorDNI(aux)].ToString());
                                }
                                break;
                        }
                        Console.WriteLine("\n\nPulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4: case ConsoleKey.NumPad4:
                        Console.WriteLine("EDICIÓN DE PERSONAS");
                        Console.WriteLine("=================================");
                        Console.Write("Introduzca el id a modificar: ");
                        auxUInt = uint.Parse(Console.ReadLine());
                        auxINT = BuscaPorID(auxUInt);
                        if (auxINT == -1)
                            Console.WriteLine("El id {0} no existe en la colección.", auxINT);
                        else
                        {
                            Console.WriteLine("La persona a modificar es: ");
                            Console.WriteLine(listado[auxINT]);
                            Console.WriteLine("\n\nIntroduzca los nuevos datos");
                            Console.WriteLine("=================================");
                            EditaPersona((int)auxINT);
                            Console.WriteLine("Persona modificada y añadida. pulsa una tecla para volver al menú...");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D5: case ConsoleKey.NumPad5:
                        Console.WriteLine("BORRAR PERSONAS");
                        Console.WriteLine("=================================");
                        Console.WriteLine("Indica que persona quieres borrar: ");
                        Console.WriteLine("1. Buscar por ID.");
                        Console.WriteLine("2. Buscar por nombre");
                        Console.WriteLine("3. Buscar por DNI");
                        Console.WriteLine("4. Dado un id SIN CONFIRMACIÓN.");
                        tecla = Console.ReadKey(true);
                        switch (tecla.Key)
                        {
                            case ConsoleKey.D1: case ConsoleKey.NumPad1:
                                Console.Write("\nIntroduzca el id a buscar: ");
                                auxUInt = uint.Parse(Console.ReadLine());
                                if(BuscaPorID(auxUInt) == -1)
                                    Console.WriteLine("El id {0} no existe en la colección.Pulsa una tecla para volver al menú.", auxUInt);
                                else
                                {
                                    Console.WriteLine("Mostrando los datos de la persona: ");
                                    Console.WriteLine(listado[BuscaPorID(auxUInt)].ToString());

                                    Console.WriteLine("\n\nQuieres eliminarla? S/n");
                                    if(tecla.Key == ConsoleKey.S)
                                    {
                                        listado[BuscaPorID(auxUInt)].Borrada = true;
                                        Console.WriteLine("Se marcó la persona como eliminada. Pulsa una tecla para volver al menú.");
                                    }
                                    else
                                        Console.WriteLine("Operación de borrar persona CANCELADA. Pulsa una tecla para volver al menú.");
                                    Console.ReadKey();
                                }
                                break;
                            case ConsoleKey.D2: case ConsoleKey.NumPad2:
                                Console.Write("\nIntroduce el/los nombre/s a buscar: ");
                                aux = Console.ReadLine();
                                auxArray = BuscaPorNombre(aux);
                                if(auxArray[0] == -1)
                                    Console.WriteLine("El nombre {0} no existe en la colección.Pulsa una tecla para volver al menú.", aux);
                                else
                                {
                                    Console.WriteLine("Mostrando los datos de la/s persona/s: ");
                                    for(int i = 0; i < auxArray.Length; i++)
                                        Console.WriteLine(listado[auxArray[i]]);

                                    Console.Write("\n\nSelecciona el id de la persona que quieres borrar:");
                                    auxUInt = uint.Parse(Console.ReadLine());
                                    Console.WriteLine("Mostrando los datos de la persona: ");
                                    Console.WriteLine(listado[BuscaPorID(auxUInt)].ToString());
                                    

                                    Console.WriteLine("\n\nQuieres eliminarla? S/n");
                                    if(tecla.Key == ConsoleKey.S)
                                    {
                                        listado[BuscaPorID(auxUInt)].Borrada = true;
                                        Console.WriteLine("Se marcó la persona como eliminada. Pulsa una tecla para volver al menú.");
                                    }
                                    else
                                        Console.WriteLine("Operación de borrar persona CANCELADA. Pulsa una tecla para volver al menú.");
                                    Console.ReadKey();
                                }
                                
                                break;
                            case ConsoleKey.D3: case ConsoleKey.NumPad3:
                                Console.Write("\nIntroduzca el DNI a buscar: ");
                                aux = Console.ReadLine();
                                if(BuscaPorDNI(aux) == -1)
                                    Console.WriteLine("El DNI {0} no existe en la colección.Pulsa una tecla para volver al menú.", aux);
                                else
                                {
                                    Console.WriteLine("Mostrando los datos de la persona: ");
                                    Console.WriteLine(listado[BuscaPorDNI(aux)].ToString());

                                    Console.WriteLine("\n\nQuieres eliminarla? S/n");
                                    if(tecla.Key == ConsoleKey.S)
                                    {
                                        listado[BuscaPorDNI(aux)].Borrada = true;
                                        Console.WriteLine("Se marcó la persona como eliminada. Pulsa una tecla para volver al menú.");
                                    }
                                    else
                                        Console.WriteLine("Operación de borrar persona CANCELADA. Pulsa una tecla para volver al menú.");
                                    Console.ReadKey();
                                }
                                break;
                            case ConsoleKey.D4: case ConsoleKey.NumPad4:
                                Console.Write("\nIntroduzca el ID a BORRAR: ");
                                auxUInt = uint.Parse(Console.ReadLine());
                                if(BuscaPorID(auxUInt) == -1)
                                    Console.WriteLine("El ID {0} no existe en la colección.Pulsa una tecla para volver al menú.", auxUInt);
                                else
                                {
                                        listado[BuscaPorID(auxUInt)].Borrada = true;
                                        Console.WriteLine("Se marcó la persona como eliminada. Pulsa una tecla para volver al menú.");
                                }
                                Console.ReadKey();
                                break;
                        }
                        Console.WriteLine("\n\nFin del listado.... Pulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D6: case ConsoleKey.NumPad6:
                        Console.WriteLine("LISTADO DE TODAS LAS PERSONAS");
                        Console.WriteLine("=================================");
                        ListarPersonas();
                        Console.WriteLine("\n\nFin del listado.... Pulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D7: case ConsoleKey.NumPad7:
                        Console.WriteLine("AMPLIACIÓN DE ARRAY");
                        Console.WriteLine("=================================");
                        Console.Write("Introduzca cuantas posiciones quiere incrementar el array: ");
                        auxUInt = uint.Parse(Console.ReadLine());
                        IncrementaArray(auxUInt);
                        Console.WriteLine("Array incrementado, pulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D8: case ConsoleKey.NumPad8:
                        Console.WriteLine("BORRADO TOTAL");
                        Console.WriteLine("=================================");
                        Console.WriteLine("¿Seguro que quiere eliminar todos los datos? S/n");
                        tecla = Console.ReadKey(true);
                        if (tecla.Key == ConsoleKey.S)
                        {
                            BorraTodo();
                            Console.WriteLine("Todos los datos fueron eliminados. Pulsa una tecla para volver al menú.");
                        }
                        else
                            Console.WriteLine("Operación de borrar CANCELADA. Pulsa una tecla para volver al menú.");
                        Console.ReadKey();
                        break;
                }

            } while (tecla.Key != ConsoleKey.Escape);

        }
        static int BuscaPorID(uint id)
        {
            for (int i = 0; i < nDatos; i++)
                if (listado[i].Id == id)
                {
                    Console.WriteLine(listado[i].ToString());
                    return i;
                }
            return -1;
        }

        static int[] BuscaPorNombre(string nombre)
        {
            int[] zero = { -1 };
            uint contador = 0;
            int[] ids;
            for(int i = 0; i < nDatos; i++)
                if(listado[i].Nombre.ToLower() == nombre.ToLower())
                    contador++;
            ids = new int[contador];
            contador = 0;
            for(int i = 0; i < nDatos; i++)
                if(listado[i].Nombre.ToLower() == nombre.ToLower())
                    ids[contador++] = (int)listado[i].Id;
            if(contador == 0)
                return zero;
            return ids;
        }

        static int BuscaPorDNI(string dni)
        {
            for(int i = 0; i < nDatos; i++)
                if(listado[i].Nombre.ToLower() == dni.ToLower())
                    return i;
            return -1;
        }

        static void CreaPersona()
        {
            string nombre = string.Empty;
            string dni = string.Empty;
            sbyte edad = 0;
            uint sueldo = 0;
            DateTime unaFecha;
            Persona unaPersona;

            Console.Write("            Introduce el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("        Introduce los apellidos: ");
            dni = Console.ReadLine();
            Console.Write("              Introduce la edad: ");
            edad = sbyte.Parse(Console.ReadLine());
            Console.Write("            Introduce el sueldo: ");
            sueldo = uint.Parse(Console.ReadLine());
            Console.Write("Introduce la fecha contratación: ");
            unaFecha = DateTime.Parse(Console.ReadLine());
            unaPersona = new Persona(nombre, dni, edad, sueldo, unaFecha, numId);

            listado[nDatos++] = unaPersona;
            numId++;
        }

        static void EditaPersona(int posicion)
        {
            string nombre = string.Empty;
            string apellidos = string.Empty;
            sbyte edad = 0;
            uint sueldo = 0;
            DateTime unaFecha;
            Persona unaPersona;
            uint id = listado[posicion].Id;

            Console.Write("            Introduce el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("        Introduce los apellidos: ");
            apellidos = Console.ReadLine();
            Console.Write("              Introduce la edad: ");
            edad = sbyte.Parse(Console.ReadLine());
            Console.Write("            Introduce el sueldo: ");
            sueldo = uint.Parse(Console.ReadLine());
            Console.Write("Introduce la fecha contratación: ");
            unaFecha = DateTime.Parse(Console.ReadLine());
            unaPersona = new Persona(nombre, apellidos, edad, sueldo, unaFecha, id);

            listado[posicion] = unaPersona;
        }

        static bool CreaPersonasAlea(int total)
        {
            string nombre = string.Empty;
            string apellidos = string.Empty;
            sbyte edad = 0;
            uint sueldo = 0;
            DateTime unaFecha;
            Persona unaPersona;
            if (nDatos + total >= listado.Length)
                return false;

            for (int i = 0; i < total; i++)
            {
                nombre = NombreAlea();
                apellidos = ApellidosAlea();
                edad = EdadAlea();
                sueldo = SueldoAlea();
                unaFecha = FechaAlea(DateTime.Parse("1/1/50"), DateTime.Now);
                unaPersona = new Persona(nombre, apellidos, edad, sueldo, unaFecha,numId);
                listado[nDatos++] = unaPersona;
                numId++;
                Thread.Sleep(10);
            }
            return true;
        }

        static string NombreAlea()
        {
            Random rnd = new Random();
            string[] nombres = { "Pepe", "Antonio", "Juan Damián", "Maria", "Josefa", "Margarita", "Lucas", "Carlos", "pablo", "Paco", "jose", "Alberto", "Ana", "Natalia", "Benito" };
            return nombres[rnd.Next(0, nombres.Length)];
        }

        static string ApellidosAlea()
        {
            Random rnd = new Random();
            string[] apellidos = { "Sánchez", "Pérez", "López", "Zelaya", "Álvarez", "García", "Jiménez", "Báez", "Camela", "Zariweya", "SoyProgramador eflwfglfgejkñw" };
            return apellidos[rnd.Next(0, apellidos.Length)] + " " + apellidos[rnd.Next(0, apellidos.Length)];
        }

        static sbyte EdadAlea()
        {
            Random rnd = new Random();
            return (sbyte)rnd.Next(120);
        }

        static uint SueldoAlea()
        {
            Random rnd = new Random();
            return (uint)rnd.Next(20000);
        }

        static DateTime FechaAlea(DateTime fInicio, DateTime fFin)
        {
            Random rnd = new Random();
            TimeSpan intervalo = fFin.Subtract(fInicio);
            int totalDias = (int)intervalo.TotalDays;

            return fInicio.AddDays(rnd.Next(totalDias));
        }

        static void BorraTodo()
        {
            nDatos = 0;
        }

        static void ListarPersonas()
        {
            Console.Clear();
            if(nDatos == 0)
                Console.WriteLine("No hay datos para mostrar, pruebe a crear una persona....");
            else
                for (int i = 0; i < nDatos; i++)
                    Console.WriteLine(listado[i]);
        }

        static void IncrementaArray(uint incremento)
        {
            Persona[] aux = new Persona[listado.Length + incremento];
            for (int i = 0; i < listado.Length; i++)
                aux[i] = listado[i];

            listado = aux;
        }

        static void UIMenu()
        {
            Console.WriteLine("1. Añadir persona.");
            Console.WriteLine("2. Añadir personas aleatorias.");
            Console.WriteLine("3. Buscar persona.");
            Console.WriteLine("4. Editar persona.");
            Console.WriteLine("5. Borrar persona.");
            Console.WriteLine("6. Listar todas las personas.");
            Console.WriteLine("7. Ampliar Array.");
            Console.WriteLine("8. Borrar todos los datos.");
        }

    }
}
