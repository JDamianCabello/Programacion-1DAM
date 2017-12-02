using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_estructuras2
{
    class Program
    {
        public struct Pambisitos
        {
            public string nombre;
            public DateTime fechaNacimiento;
            public float estatura;
            public string dni;
        }

        static int nDatos = 0;
        static Pambisitos[] listaPambisitos;

        static void Main(string[] args)
        {
            const int NMAXPERSONAS = 10;
            listaPambisitos = new Pambisitos[NMAXPERSONAS];
        }

        static bool addPersona(Pambisitos p)
        {
            if(nDatos >= listaPambisitos.Length)
                return false;
            listaPambisitos[nDatos++] = p;
            return true;
        }

        static void Listar()
        {
            if(nDatos == 0)
            {
                Console.WriteLine("La lista esta vacía...");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Nombre\t\tFecha Nacimiento\tEstatura\tDNI");
            for(int i = 0; i < nDatos; i++)
            {
                Console.Write("{0}\t\t{1}\t{2}\t{3}", listaPambisitos[i].nombre, listaPambisitos[i].fechaNacimiento, listaPambisitos[i].estatura, listaPambisitos[i].dni);
            }
            Console.WriteLine("\n\nFin del listado. Pulse una tecla para salir.");
            Console.ReadKey();
        }
    }
}
