using System;

namespace App_Estructuras
{
    class Program
    {
        //Contiene los datos personales de una persona
        public struct Persona
        {
            //albañil de la clase
            public Persona(string nombre, DateTime fechaNacimiento, float estatura, string dni, string privado)
            {
                _Privado = privado;
                _Nombre = nombre;
                _FechaNacimiento = fechaNacimiento;
                _Estatura = estatura;
                _Dni = dni;
            }

            //Campos/Propiedades
            public string _Nombre;
            public DateTime _FechaNacimiento;
            public float _Estatura;
            public string _Dni;
            private string _Privado;

            //Métodos
            public string Privado()
            {
                return this._Privado;
            }

            public void SetPrivado(string privado)
            {
                if(privado == "nulo")
                    return;
                _Privado = privado;
            }


 
        }

        static void Main(string[] args)
        {
            Persona unaPersona = new Persona("Pepe",DateTime.Parse("01/01/2000"),1.85F,"25605387Q","Campo privado");
            VerDatos(unaPersona);
            unaPersona.SetPrivado("He cambiado el campo privado");
            VerDatos(unaPersona);
        }

#region Métodos propios

        static void VerDatos(Persona p)
        {
            Console.WriteLine("Datos de una persona");
            Console.WriteLine("=================================");
            Console.WriteLine("     Nombre: {0}", p._Nombre);
            Console.WriteLine("    Naciste: {0}", p._FechaNacimiento.ToLongDateString());
            Console.WriteLine("      Mides: {0}", p._Estatura);
            Console.WriteLine("        DNI: {0}", p._Dni);
            Console.WriteLine("    Privado: {0}",p.Privado());
        }

        static Persona LeerDatos()
        {
            Persona p = new Persona();
            bool correcto = false;


            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Leer datos de una persona");
                    Console.WriteLine("=================================");
                    Console.Write("     Nombre: ");
                    p._Nombre = Console.ReadLine();
                    Console.Write("    Naciste: ");
                    p._FechaNacimiento = DateTime.Parse(Console.ReadLine());
                    Console.Write("      Mides: ");
                    p._Estatura = float.Parse(Console.ReadLine());
                    Console.Write("        DNI: ");
                    p._Dni = Console.ReadLine();
                    correcto = true;
                }
                catch(Exception)
                {
                    Console.WriteLine("\nHORROR: ERROR en la entrada de datos....");
                    Console.ReadLine();
                } 
            } while(!correcto);

            return p;
        }
#endregion
    }
}
