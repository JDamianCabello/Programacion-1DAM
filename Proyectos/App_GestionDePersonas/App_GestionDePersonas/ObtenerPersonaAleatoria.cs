using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_GestionDePersonas
{
    public class ObtenerPersonaAleatoria
    {
        static string[] nombres = {"Javier","Raul", "Bilal", "Fran","Manuel","Ignacio", "Eustaquio", "Eliseo", "Aitor","Vyacheslav", "Ismael", "Sebas", "Ana", "Muzska","Rubén","Alejandro", "Chemita"};
        static string[] apellidos = {"Miguel","Amado","Prieto", "Perez" ,"González","Toro","Roldán","Moya", "Rivas", "Tilla", "Menta","García","Shylyayev","Bueno", "Turbado", "Sánchez", "Zúñiga"};
        static Random rnd = new Random();

        public static Persona Crear()
        {
            Persona p = new Persona(CrearNombre(), CrearApellido(), CrearFechaNacimiento(), CrearEstatura());
            return p;
        }

        //Método privado
        static string CrearNombre()
        {
            return nombres[rnd.Next(nombres.Length)];
        }

        static string CrearApellido()
        {
            return apellidos[rnd.Next(apellidos.Length)] + " " + apellidos[rnd.Next(apellidos.Length)];
        }

        static DateTime CrearFechaNacimiento()
        {
            //Últimos 20 años aproximadamente
            DateTime fecha = new DateTime();
            fecha = DateTime.Now - TimeSpan.FromDays(rnd.Next(1, 365 * 20));
            return fecha;
        }

        /// <summary>
        /// Crea estatura aleatoria entre 1.50 y 2.10 aproximadamente
        /// </summary>
        /// <returns>estatura</returns>
        static double CrearEstatura()
        {
            double estatura = rnd.Next(150, 211);
            estatura /= 100;
            return estatura;
        }

    }
}
